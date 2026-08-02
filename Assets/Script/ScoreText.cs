 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    public TextMeshProUGUI text;

    public void setscore(int value)
    {
        text.text = value.ToString();
    }
    
}
