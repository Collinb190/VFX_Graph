using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    void Start()
    {
        // Hide the default system cursor
        Cursor.visible = false;
    }

    void Update()
    {
        // Get the mouse position in screen space
        Vector3 mousePosition = Input.mousePosition;

        // Set a fixed distance from the camera (adjust for 3D depth)
        mousePosition.z = 10f; // Adjust this value based on your camera setup

        // Convert screen position to world position
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        // Move the object to the mouse position
        transform.position = worldPosition;
    }
}
