using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f; // Player movement speed
    public Camera playerCamera; // Reference to the camera
    public float rotationSpeed = 15f; // Camera rotation speed

    private Rigidbody rb;

    private Transform playerCameraTransform;
    private Vector3 cameraOffset;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        
        playerCameraTransform = Camera.main.transform;
        cameraOffset = playerCameraTransform.position - transform.position;

        Cursor.lockState = CursorLockMode.Locked; // Lock cursor to the game window

    }

    private void FixedUpdate()
    {
        // Get input axes for movement
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Calculate movement direction
        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);
        movement = movement.normalized * speed * Time.deltaTime;

        // Apply movement to the player
        rb.MovePosition(transform.position + movement);

        // Get mouse rotation input
        float rotationY = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
        float rotationX = Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;


        // Rotate the player along the x,y-axis
        transform.Rotate(0f, rotationX, 0f);
        transform.Rotate(0f, rotationY, 0f);


        // Update camera position to follow the player
        playerCamera.transform.position = transform.position;
    }
}


