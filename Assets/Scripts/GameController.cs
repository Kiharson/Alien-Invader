using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public float speed;

    public int score;
    public Text scoreDisplay;

    public int turretsLeft = 3;
    public Text turretsLeftDisplay;

    public int wavesKilled = 0;
    public Text wavesKilledDisplay;

    public bool canShoot = true;

    public GameObject gamePanel;
    public GameObject gameOverPanel;

    public Text gameOverScoreDisplay;
    public Text gameOverWavesKilledDisplay;

    void Update()
    {
        scoreDisplay.text = "SCORE: " + score;
        turretsLeftDisplay.text = "TURRETS: " + turretsLeft;
        wavesKilledDisplay.text = "WAVES KILLED: " + wavesKilled;
    }

    public void GameOver()
    {
        Destroy(gamePanel);

        gameOverScoreDisplay.text = "SCORE: " + score;
        gameOverWavesKilledDisplay.text = "WAVES KILLED: " + wavesKilled;
        gameOverPanel.SetActive(true);
    }

    public void OnRestartButtonClicked()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void OnExitButtonClicked()
    {
        Application.Quit();
    }

    public void OnPlayButtonClicked()
    {
        SceneManager.LoadScene("MainScene");
    }
}
