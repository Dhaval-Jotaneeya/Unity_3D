using UnityEngine;

public class follower : MonoBehaviour
{
    public Transform camera_position;
    public Vector3 offset;

    void Update()
    {
        transform.position = camera_position.position + offset;
    }
}
