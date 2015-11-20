using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	// PUBLIC INSTANCE VARIABLES
	public Text scoreText;
	public Text livesText;
    public Text gameOverText;
    public Text finalScoreText;
    public Text restartText;

    // PRIVATE INSTANCE VARIABLES
    private int scoreValue = 0;
	private int livesValue = 5;
    private bool gameOver;
    private bool restart;


    // Use this for initialization
    void Start () {
        gameOver = false;
        restart = false;
        this.gameOverText.enabled = false;
        this.finalScoreText.enabled = false;
        this.restartText.enabled = false;
        this.UpdateLives();
        this.UpdateScore();
	}
	
	// Update is called once per frame
	void Update () {
        if (restart)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                Application.LoadLevel(Application.loadedLevel);
            }
        }

    }

    // When player collects a star
    public void GainScore(int newScoreValue)
    {
        scoreValue += newScoreValue;
        UpdateScore();
    }

    // Updates score value from above
    public void UpdateScore()
    {
        scoreText.text = "Score: " + scoreValue;
    }

    // When player collides with an enemy
    public void LoseLife(int newLifeValue)
    {
        livesValue -= newLifeValue;
        UpdateLives();
    }

    // Updates lives value from above
    public void UpdateLives()
    {
        livesText.text = "Lives: " + livesValue;

        if (livesValue == 0)
        {
            this.GameOver();
        }
    }

    // When lives value hits zero
    private void GameOver()
    {
        gameOver = true;
        this.scoreText.enabled = false;
        this.livesText.enabled = false;
        this.gameOverText.enabled = true;
        this.finalScoreText.enabled = true;
        this.finalScoreText.text = "Final Score: " + this.scoreValue;

        //Meassge to press "R" to play again
        if (gameOver)
        {
            this.restartText.enabled = true;
            this.restartText.text = "Press 'R' to play again";
            restart = true;
        }
    }
}
