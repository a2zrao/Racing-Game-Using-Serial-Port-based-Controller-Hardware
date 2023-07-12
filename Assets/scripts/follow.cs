using UnityEngine;

public class follow : MonoBehaviour
{
    public Transform target;  // Object to follow

    void LateUpdate()
    {
        // Get the position and rotation of the target object
        Vector3 targetPosition = target.position;
        Quaternion targetRotation = target.rotation;

        // Apply the same position and rotation to the follower object
        transform.position = targetPosition;
        transform.rotation = targetRotation;
    }
}
