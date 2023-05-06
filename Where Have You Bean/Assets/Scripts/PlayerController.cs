using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;

    public GameObject playerAtDockCamera;
    public Camera playerAtDock;

    public GameObject playerAtSeaCamera;
    public Camera playerAtSea;

    public Rigidbody p1; //player object one
    public Rigidbody p2; //player object two

    private bool atSea = false;
    private Rigidbody rb;
    private Vector3 cameraposition;

    void Start()
    {
        rb = p1;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            atSea = !atSea;
        }
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        float moveVertical = Input.GetAxis("Vertical");

        if (!atSea)
        {
            if (rb == p2)
            {
                rb.velocity = Vector3.zero;
                rb = p1;
            }
            EnableDock();
            rb.AddForce(new Vector3(moveHorizontal, 0.0f, moveVertical) * speed);
        }
        else
        {
            if (rb == p1)
            {
                rb.velocity = Vector3.zero;
                rb = p2;
            }
            EnableSea();
            rb.AddForce(new Vector3(0.0f, 0.0f, moveVertical) * speed);

        }
    }
    void EnableSea()
    {
        playerAtDock.enabled = false;
        playerAtSeaCamera.SetActive(true);
        playerAtSea.enabled = true;

    }
    void EnableDock()
    {
        playerAtDock.enabled = true;
        playerAtSeaCamera.SetActive(false);
        playerAtSea.enabled = false;

    }
}