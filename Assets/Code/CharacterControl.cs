using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //movement and rotation
        movement = ((transform.forward * Input.GetAxis("Vertical")) + (transform.right * Input.GetAxis("Horizontal"))) * moveSpeed;
        rotation += Input.GetAxis("Mouse X") * rotationSpeed;
        transform.rotation = Quaternion.Euler(new Vector3(0f, rotation, 0f));
        camRotation -= Input.GetAxis("Mouse Y") * camRotationSpeed;
        camRotation = Mathf.Clamp(camRotation, -40f, 40f);
        cam.transform.localRotation = Quaternion.Euler(new Vector3(camRotation, 0f, 0f));
        rb.velocity = new Vector3(movement.x, rb.velocity.y, movement.z);
        //pickupLocation.transform.position = Input.mousePosition;
        if (Input.GetKeyDown(KeyCode.E))
        {
            Pickup();
        }
        
        if (holding)
        {
            if (Vector3.Distance(held.transform.position, pickupLocation.transform.position)>0.1f)
			{
                Vector3 moveDirection = (pickupLocation.transform.position - held.transform.position);
                held.GetComponent<Rigidbody>().AddForce(moveDirection * heldForce);
			}
            else if (Vector3.Distance(held.transform.position, pickupLocation.transform.position) > 0.001f)
            {
                Vector3 moveDirection = (pickupLocation.transform.position - held.transform.position);
                held.GetComponent<Rigidbody>().AddForce(moveDirection);
            }
            else
			{
                held.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
            //held.transform.position = Vector3.Lerp(held.transform.position, pickupLocation.transform.position, Time.deltaTime);
            held.transform.rotation = Quaternion.Euler(new Vector3(held.transform.rotation.x, rotation, held.transform.rotation.y));
        }
    }

    void Pickup()
    {
        RaycastHit hit;
        int layerMask = 1 << 8;
        if (Physics.Raycast(cam.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition), out hit, pickupDistance, layerMask))
        {
            Debug.Log("Hit");
            Debug.DrawRay(cam.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition).origin, cam.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition).direction * pickupDistance, Color.yellow, 10);
            hit.collider.transform.parent = pickupLocation.transform;
            hit.collider.transform.position = pickupLocation.transform.position;
            hit.collider.attachedRigidbody.useGravity = false;
            held = hit.collider.gameObject;
            held.GetComponent<Rigidbody>().drag = 10f;
            holding = true;
        }
    }
}
