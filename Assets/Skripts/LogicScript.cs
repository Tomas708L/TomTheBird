using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;            // Player's current score
    public Text scoreText;             // UI Text to display score
    public GameObject gameOverScreen;  // Game Over panel
    public GameObject startMenu;       // Start Menu panel

    [ContextMenu("Increase Score")]

    void Start()
    {
        // Pause the game at the start
        Time.timeScale = 0f;

        // Show Start Menu
        startMenu.SetActive(true);

        // Hide Game Over screen
        gameOverScreen.SetActive(false);

        // Hide score at start
        scoreText.gameObject.SetActive(false);
    }

    // Add points to the score
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    // Restart the game by reloading the current scene
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }

    // Trigger Game Over screen
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        Time.timeScale = 0f; // Stop the game
    }

    // Start the game from the Start Menu
    public void startGame()
    {
        Debug.Log("Start Game");

        // Hide Start Menu and show score
        startMenu.SetActive(false);
        scoreText.gameObject.SetActive(true);

        // Start the game
        Time.timeScale = 1f;
    }
}
