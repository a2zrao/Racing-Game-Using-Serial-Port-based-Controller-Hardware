using UnityEngine;

public class ObjectFollower : MonoBehaviour
{
    public Transform target;  // Object to follow
    public float height = 10f;  // Height above the target
    public float smoothSpeed = 0.125f;  // Smoothing factor for camera movement

    private Vector3 offset;  // Offset from the target

    void Start()
    {
        // Calculate the offset from the target
        offset = new Vector3(0f, height, 0f);
    }

    void LateUpdate()
    {
        // Calculate the desired position for the camera
        Vector3 desiredPosition = target.position + offset;

        // Use smooth damping to move the camera towards the desired position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Set the new position of the camera
        transform.position = smoothedPosition;

        // Look at the target object
        transform.LookAt(target);
    }
}
