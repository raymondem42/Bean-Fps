using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerMovement : MonoBehaviour
{


    private Rigidbody rb;

    public LayerMask layerMask;
    public bool Grounded;

    public float moveSpeed = 4500;
    public float jumpForce = 10f;

    private Vector3 playerScale;

    float x, y;
    bool jumping, crouching;
    private Vector3 normalVector = Vector3.up;


    private bool readyToJump = true;
    public float jumpCooldown = .25f;

    public float stopAnimation = 0.5f;
   

    //Crouching
    private Vector3 crouchScalee = new Vector3(1, 0.5f, 1);

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody>();
        playerScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {

        float x = Input.GetAxisRaw("Horizontal") * moveSpeed;
        float y = Input.GetAxisRaw("Vertical") * moveSpeed;
        crouching = Input.GetKey(KeyCode.LeftControl);
        jumping = Input.GetKey(KeyCode.Space);

        Grounded = Physics.CheckSphere(new Vector3(transform.position.x, transform.position.y - 1, transform.position.z), 2f, layerMask);

        if (readyToJump && jumping) Jump();


        /*
        if (Input.GetKeyDown(KeyCode.Space))
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
        */
        Vector3 movePos = transform.right * x + transform.forward * y;
        Vector3 newMovePos = new Vector3(movePos.x, rb.velocity.y, movePos.z);

        rb.velocity = newMovePos;

        if (Input.GetKeyDown(KeyCode.LeftControl))
            StartCrouch();
        if (Input.GetKeyUp(KeyCode.LeftControl))
            StopCrouch();
    
  
        }


    private void Jump()
    {
        if (Grounded && readyToJump)
        {

            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);

            Invoke(nameof(ResetJump), jumpCooldown);


        }
    }

    private void ResetJump()
    {
        readyToJump = true;
    }

    private void StartCrouch()
    {
        transform.localScale = crouchScalee;
        transform.position = new Vector3(transform.position.x, transform.position.y - 0.5f, transform.position.z);

    }

    private void StopCrouch()
    {
        transform.localScale = playerScale;
        transform.position = new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z);
    }


}