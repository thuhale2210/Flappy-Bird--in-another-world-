using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public static int playerHighestScore;
    public Text scoreText;
    public Text highestScoreText;
    public GameObject gameOverScreen;
    public AudioSource dingSFX;

    void Update()
    {
        highestScoreText.text = "High Score: " + playerHighestScore.ToString();
        saveHighScore();
    }

    [ContextMenu("Increase Score") ]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
        dingSFX.Play();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        highestScoreText.text = "High Score: " + playerHighestScore.ToString();
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        saveHighScore();
    }

    public void saveHighScore()
    {
        if (playerScore > playerHighestScore)
        {
            playerHighestScore = playerScore;
            PlayerPrefs.SetInt("playerHighestScore", playerScore);
            highestScoreText.text = "High Score: " + playerHighestScore.ToString();
        }
    }
}
