using UnityEngine;

public class Bird : MonoBehaviour
{
    public Rigidbody2D myRigidbody; // Bird's physics component
    public float flapStrength;       // How strong it flaps
    public LogicScript logic;       // Reference to game logic
    public bool birdIsAlive = true; // Can the bird flap?

    void Start()
    {
        // Find the Logic object in the scene
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }
    
    void Update()
    {
        // If space is pressed and bird is alive, flap
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidbody.linearVelocity = Vector2.up * flapStrength;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // When bird hits something, game over
        logic.gameOver();
        birdIsAlive = false;
    }
}
