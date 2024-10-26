using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] Transform player;  // Reference to the player object
    [SerializeField] float followSpeed = 5f;  // Speed of the camera following
    [SerializeField] Vector3 offset = new Vector3(0, 5, -10);  // Offset position of the camera

    void LateUpdate()
    {
        Vector3 targetPosition = player.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);
    }
}
