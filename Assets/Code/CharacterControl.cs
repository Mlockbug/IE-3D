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
        Mathf.Clamp(camRotation, -40f, 40f);
        cam.transform.localRotation = Quaternion.Euler(new Vector3(camRotation, 0f, 0f));
        rb.velocity = new Vector3(movement.x, rb.velocity.y, movement.z);

        if (Input.GetKeyDown(KeyCode.E))
        {
            Pickup();
        }
    }

    void Pickup()
    {
        RaycastHit hit;
        int layerMask = 1 << 8;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 20f, layerMask))
        {
            Debug.Log("Hit");
        }
    }
}
