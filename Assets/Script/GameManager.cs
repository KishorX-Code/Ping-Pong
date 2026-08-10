using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int scorePlayer1, scorePlayer2;
    public ScoreText scoreTextLeft, scoreTextRight;
    public Action onReset;
    public GameObject winPanel;
    public TMPro.TextMeshProUGUI winText;
    public GameObject pausePanel;

    private void Awake()
    {
        if (instance)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    public void OnScoreZoneReached(int id)
    {
        onReset?.Invoke();

        if (id == 1)
        {
            scorePlayer1++;
        }
        else if (id == 2)
        {
            scorePlayer2++;
        }

        UpdateScores();
        CheckWinner();
    }

    private void UpdateScores()
    {
        scoreTextLeft.setscore(scorePlayer1);
        scoreTextRight.setscore(scorePlayer2);
    }

    private void CheckWinner()
    {
        if (scorePlayer1 >= 10)
        {
            winText.text = "Blue Wins";
            winText.color = Color.blue;
            winPanel.SetActive(true);
            Time.timeScale = 0;
        }
        else if (scorePlayer2 >= 10)
        {
            winText.text = "Yellow Wins";
            winText.color = Color.yellow;
            winPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Home()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Main Menu");
    }
    public void PauseGame()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0;
    }
    public void ContinueGame()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1;
    }
    
}
