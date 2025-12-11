using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;   // Speed at which the pipe moves left
    public float deadZone = -45;  // X-position at which the pipe gets destroyed

    // Start is called once when the script is initialized
    void Start()
    {
        // No initialization needed for now
    }

    // Update is called once per frame
    void Update()
    {
        // Move the pipe to the left every frame
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        // Check if the pipe has moved past the dead zone
        if (transform.position.x < deadZone)
        {
            Debug.Log("Pipe Deleted"); // Optional debug log
            Destroy(gameObject);       // Remove the pipe from the scene
        }
    }
}
