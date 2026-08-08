using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int scorePlayer1, scorePlayer2;
    public ScoreText scoreTextLeft, scoreTextRight;
    public Action onReset;
    public GameObject winPanel;
    public TMPro.TextMeshProUGUI winText;
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
            scorePlayer1++;
        
         if (id == 2)
        
            scorePlayer2++;
        
        UpdateScores();
    }
            private void UpdateScores()
    {
        scoreTextLeft.setscore(scorePlayer1);
        scoreTextRight.setscore(scorePlayer2);
    }
    private void CheckWinner()
    {
        if (scorePlayer1 > +10)
        {
            winText.text = "PLAYER 1 WINS";
            winText.color = Color.blue;
            winPanel.SetActive(true);
            Time.timeScale = 0;

        }
        else if(scorePlayer2 >= 10){
            winText.text = "PLAYER 2 WINS";
            winText.color = Color.yellow;
            winPanel.SetActive(true);
            Time.timeScale = 0;

        } 
    }
}
