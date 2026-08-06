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
}
