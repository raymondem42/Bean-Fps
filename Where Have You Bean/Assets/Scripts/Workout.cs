using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Workout : MonoBehaviour
{


    private Rigidbody rb;

    public LayerMask layerMask;
    public LayerMask yeeters;

    public bool Grounded;
    public bool yeet1;

    public float moveSpeed = 50;
    public float jumpForce = 25;

    //we're going to see if the player is touching the ammo pack

    private Vector3 playerScale;

    float x, y;
    bool jumping, crouching;
    private Vector3 normalVector = Vector3.up;

    private bool readyToJump = true;
    public float jumpCooldown = .25f;

    public float stopAnimation = 0.5f;


    public float coolDown = 5;
    public float coolDownTimer = 1;

    public float workout = 5;
    public float workoutTimer = 0;

    public float beanspeed = 0;

    public float still = 8;
  
    public int i = 0;
    public int n = 0;

    public ParticleSystem show;

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

        yeet1 = Physics.CheckSphere(new Vector3(transform.position.x, transform.position.y - 1, transform.position.z), 1f, yeeters);


        if (readyToJump && jumping)
        {
            Jump();
        }

        Vector3 movePos = transform.right * x + transform.forward * y;
        Vector3 newMovePos = new Vector3(movePos.x, rb.velocity.y, movePos.z);

        rb.velocity = newMovePos;

        if (Input.GetKeyDown(KeyCode.LeftControl))
            StartCrouch();
        if (Input.GetKeyUp(KeyCode.LeftControl))
            StopCrouch();

        //condider modding cooldowntimer here
        if (coolDown > 0 && coolDown < 6 &&beanspeed %2 ==0)
        {
            coolDown -= Time.deltaTime;
        }
        

        if (coolDown < 0)
        {
            coolDown =0;
        }
        

        if (Input.GetKeyDown(KeyCode.F) && coolDown == 0 && beanspeed %2 ==0)
        {
            Debug.Log("Progress");
            moveSpeed = 120;
            workout = 5;
            beanspeed++;
            CrossFitSound1();
        }

        if(beanspeed %2 == 1)
        {
            workout -= Time.deltaTime;
        }

        if (workout < 0)
        {
            coolDown = 5;
            moveSpeed = 50;
            workout = 0;
            beanspeed++;
        }


        if ((i <1 && Grounded && (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))))
        {
            walksound();
            i++;
            }

        if (!Grounded)
        {
            stopwalk();
        }

        if ((i > 1 || !Grounded || ((!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.D)))))
        {
            stopwalk();
        }

        if (yeet1)
        {
            yeeter();
        }

        if ((((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)))))
            
        {
            still = 8;
            n = 0;
            stopNoMove();
            show.Stop();
        }


        if (((n < 1 && (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.D)))))
        {
            still -= Time.deltaTime;
            if (still <= 0)
            {
                test();
                n++;
                show.Play();
            }
        }

    }

    void stopNoMove()
    {
        NoMove.stopTest();
    }
    void test()
    {
        NoMove.playTest();
    }

    void yeeter()
    {
        Yeet.playYeet();
    }


    /*
        private void CrossfitMode() {

            moveSpeed = 120;

        }

        private void chillMode()
        {
            moveSpeed = 45;
        }
    */

 

    void walksound()
    {
        walkSound.playwalk();

    }

    void CrossFitSound1()
    {
        CrossFitSound.playCrossfit();
    }

    void stopwalk()
    {
        walkSound.stopWalk();
        i = 0;
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