using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterControl : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody rb;
    public GameObject cam;
    float camRotation = 0f;
    public float camRotationSpeed = 1f;
    public float rotationSpeed = 1f;
    float rotation = 0f;
    Vector3 movement;
    public float moveSpeed = 5f;


    public float pickupDistance = 5f;
    public GameObject pickupLocation;
    bool holding = false;
    GameObject held;
    public float heldForce = 200f;
    public float throwForce = 50f;


    public GameObject poem;
    public Text poemText;
    public Image poemBackground;
    int lines;


    bool onLadder = false;
    Vector3 ladderPos;
    public Transform sewerSpawn;
    public Transform townSpawn;
    public Transform mansionSpawn;
    bool readyForDialogue;
    bool inDialogue = false;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (!(inDialogue))
        {
            //movement and rotation
            movement = ((transform.forward * Input.GetAxis("Vertical")) + (transform.right * Input.GetAxis("Horizontal"))) * moveSpeed;
            rotation += Input.GetAxis("Mouse X") * rotationSpeed;
            transform.rotation = Quaternion.Euler(new Vector3(0f, rotation, 0f));
            camRotation -= Input.GetAxis("Mouse Y") * camRotationSpeed;
            camRotation = Mathf.Clamp(camRotation, -80f, 80f);
            cam.transform.localRotation = Quaternion.Euler(new Vector3(camRotation, 0f, 0f));

            if (onLadder && Input.GetKey(KeyCode.Space))
            {
                onLadder = false;
            }
            if (onLadder)
            {
                movement = new Vector3((ladderPos.x-transform.position.x) * Input.GetAxis("Vertical"),0f,(ladderPos.z-transform.position.z) * Input.GetAxis("Horizontal")) * moveSpeed;
                rb.velocity = new Vector3(0f,movement.x/7, movement.z * -1);
            }
            else
            {
                rb.velocity = new Vector3(movement.x, rb.velocity.y, movement.z);
            }
            //pickupLocation.transform.position = Input.mousePosition;
            if (Input.GetKeyDown(KeyCode.E) && readyForDialogue)
            {
                TryForDialogue();
            }
            else if (Input.GetKeyDown(KeyCode.E))
            {
                PickupAndDrop(0f);
            }
            if (Input.GetMouseButtonDown(0))
            {
                PickupAndDrop(throwForce);
            }
            if (Input.GetKey(KeyCode.LeftShift))
            {
                moveSpeed = 10f;
            }
            else
            {
                moveSpeed = 5f;
            }
            if (Input.GetKey(KeyCode.Tab))
            {
                poem.SetActive(true);
            }
            else
            {
                poem.SetActive(false);
            }

            if (holding)
            {
                held.transform.position = pickupLocation.transform.position;
                held.transform.rotation = Quaternion.Euler(new Vector3(held.transform.rotation.x, rotation, held.transform.rotation.y));
            }
        }
    }

    public void PickupAndDrop(float force)
    {
        if (holding)
        {
            held.transform.parent = null;
            held.GetComponent<Rigidbody>().useGravity = true;
            held.GetComponent<Rigidbody>().drag = 0f;
            held.GetComponent<Rigidbody>().velocity = Vector3.zero;
            if (rb.velocity.magnitude > 1f)
			{
                held.GetComponent<Rigidbody>().AddForce((held.transform.position - transform.position) * force * (rb.velocity.magnitude/2));
			}
            else
			{
                held.GetComponent<Rigidbody>().AddForce((held.transform.position - transform.position) * force);

            }
            Destroy(held.GetComponent<ForceDrop>());
            held = null;
            holding = false;
        }
        else
        {
            RaycastHit hit;
            LayerMask layerMask = 1 << 8;
            if (Physics.Raycast(cam.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition), out hit, pickupDistance, layerMask))
            {
                Debug.Log("Hit");
                Debug.DrawRay(cam.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition).origin, cam.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition).direction * pickupDistance, Color.yellow, 10);
                hit.collider.transform.parent = pickupLocation.transform;
                hit.collider.transform.position = pickupLocation.transform.position;
                hit.collider.attachedRigidbody.useGravity = false;
                held = hit.collider.gameObject;
                held.GetComponent<Rigidbody>().drag = 10f;
                held.AddComponent<ForceDrop>();
                holding = true;
                if (hit.collider.tag == "barrel")
				{
                    held.GetComponent<BarrelLogic>().pickedUp = true;
				}
            }
        }
    }

    public void PoemExtention(int impact)
	{
        lines += impact;
        if (lines > 16 || lines == 15)
		{
            lines = 16;
		}
        poemText.GetComponent<RectTransform>().sizeDelta = new Vector2(350, (lines* 15.1071f));
        poemBackground.GetComponent<RectTransform>().sizeDelta = new Vector2(375, poemText.GetComponent<RectTransform>().rect.height + 25);
    }

	private void OnTriggerEnter(Collider other)
	{
        switch (other.tag)
        {
            case "Ladder":
                ladderPos = other.transform.position;
                onLadder = true;
                break;
            case "SewerChange":
                transform.position = sewerSpawn.position;
                break;
            case "TownChange":
                transform.position = townSpawn.position;
                break;
			case "MansionChange":
				transform.position = mansionSpawn.position;
				break;
			case "npc":
                readyForDialogue = true;
                break;
        }
    }

    private void OnTriggerExit(Collider other)
	{
        switch (other.tag)
		{
            case "Ladder":
                onLadder = false;
                break;
            case "npc":
                readyForDialogue = false;
                break;
        }
    }

    public void TryForDialogue()
    {
        RaycastHit hit;
        LayerMask layerMask = 1 << 8;
        if (Physics.Raycast(cam.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition), out hit, pickupDistance, layerMask))
        {
            PickupAndDrop(0f);
        }
        else if(Physics.Raycast(cam.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition), out hit, pickupDistance, 1 << 9))
        {
            inDialogue = true;
            rb.velocity = Vector3.zero;
            hit.collider.GetComponent<DialogueLogic>().enabled = true;
            hit.collider.GetComponent<DialogueLogic>().ReadyForDialogue();
            Debug.Log("E");
		}
    }

    public void OutOfDialogue()
	{
        inDialogue = false;
	}
}
