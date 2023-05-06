using UnityEngine;

public class MoveCamera : MonoBehaviour
{

    public Transform player;

    public float MouseSensitivity = 2;

    private float x = 0;
    private float y = 0;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        x += -Input.GetAxis("Mouse Y") * MouseSensitivity;
        y += Input.GetAxis("Mouse X") * MouseSensitivity;

        x = Mathf.Clamp(x, -90, 90);

        transform.localRotation = Quaternion.Euler(x, y, 0);
        player.transform.localRotation = Quaternion.Euler(x, y, 0);
        



        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (Cursor.lockState == CursorLockMode.Locked)
            {
                Cursor.lockState = CursorLockMode.None;
            }
            if (Cursor.lockState == CursorLockMode.Locked)
                Cursor.lockState = CursorLockMode.None;
        }

    }
}
