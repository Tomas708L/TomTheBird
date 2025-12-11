using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logic; // Reference to the game logic script

    // Start is called once when the script is initialized
    void Start()
    {
        // Find the object tagged "Logic" in the scene and get its LogicScript component
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

        // Debug to confirm the LogicScript was found
        Debug.Log("Logic found: " + logic);
    }

    // Called automatically when another collider enters this trigger collider
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        // Log the object that triggered this collider
        Debug.Log("TRIGGERED WITH: " + collision.gameObject.name);

        // Check if the colliding object is on layer 3 (usually the player/bird layer)
        if(collision.gameObject.layer == 3)
        {
            Debug.Log("Player passed the middle of the pipe");

            // Add 1 point to the player's score
            logic.addScore(1);
        }
    }
}

