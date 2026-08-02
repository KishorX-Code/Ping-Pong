using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int scorePlayer1, scorePlayer2;
    public ScoreText scoreTextLeft, scoreTextRight;
    public void OnScoreZoneReached(int id)
    {
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
