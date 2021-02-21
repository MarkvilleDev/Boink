using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    public float speedofMove;
    //public Rigidbody rigid;
    public bool mouseMove;
    public Transform cam;
    public float jumpPower;
    public float velocityofRigidY;
    public CharacterController character;
    Vector3 gravityMovement;

    //create a gravity variable to make the object go down quicker
    public float gravity = -9f;

    // Start is called before the first frame update
    void Start()
    {
        //rigid = GetComponent<Rigidbody>();
        character = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        //velocityofRigidY = rigid.velocity.y;
        //cam = transform.GetChild(6);
    }

    // Update is called once per frame
    void Update()
    {
        // wsad movement
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;
        character.Move(move * Time.deltaTime * speedofMove);

        velocityofRigidY += gravity * Time.deltaTime;
        gravityMovement = new Vector3(0, velocityofRigidY, 0);
        character.Move(gravityMovement);


        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        Vector3 quatwholeBody = new Vector3(0, mouseX, 0);
        Vector3 quatHalfBody = new Vector3(-mouseY, 0, 0);


        transform.Rotate(quatwholeBody);
        cam.Rotate(quatHalfBody);

        if (character.isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                velocityofRigidY = jumpPower * Time.deltaTime;
            }
        }

    }
}
