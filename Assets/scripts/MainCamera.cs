using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public float rotationSpeed = 5f; // Camera rotation speed

    private float rotationX = 0f;

    private void Update()
    {
        // Get mouse rotation input
        float rotationY = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;

        // Rotate the player along the y-axis
        transform.Rotate(0f, rotationY, 0f);

        // Get mouse rotation input for camera
        float rotationXDelta = Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;

        // Accumulate the rotation for vertical camera movement
        rotationX -= rotationXDelta;

        // Clamp the vertical rotation between -90 and 90 degrees to limit camera rotation
        rotationX = Mathf.Clamp(rotationX, -90f, 90f);

        // Apply rotation to the camera
        transform.localRotation = Quaternion.Euler(rotationX, transform.localRotation.eulerAngles.y, 0f);
    }
}
