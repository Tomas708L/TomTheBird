using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject Pipe;       // Prefab of the pipe to spawn
    public float spawnRate = 2;   // Time in seconds between spawns
    private float timer = 0;      // Timer to track when to spawn next pipe

    public float heightOffset = 10; // Range for random vertical position

    // Start is called once when the script is initialized
    void Start()
    {
        // Spawn the first pipe immediately
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        // Increment the timer until it reaches spawnRate
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            // Time to spawn a new pipe
            spawnPipe();
            timer = 0; // Reset the timer
        }
    }

    // Method to spawn a new pipe
    void spawnPipe()
    {
        // Calculate vertical range for the pipe
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        // Spawn a new pipe at a random vertical position within the range
        Instantiate(
            Pipe, 
            new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), 
            transform.rotation
        );
    }
}
