using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class countdown : MonoBehaviour
{
    public TextMeshProUGUI countdowntext;
    public AudioSource audioSource;
    public AudioClip countdownSound;
    private void Start()
    {
        StartCoroutine(StartCountdown());
    }
    IEnumerator StartCountdown() 
    {
        Time.timeScale = 0;

        audioSource.PlayOneShot(countdownSound);
        countdowntext.text = "3";
        yield return new WaitForSecondsRealtime(1);

        

        countdowntext.text = "2";
        yield return new WaitForSecondsRealtime(1);

        countdowntext.text = "1";
        yield return new WaitForSecondsRealtime(1);

        countdowntext.text = "Go";
        Time.timeScale = 1;
        yield return new WaitForSecondsRealtime(1);
        countdowntext.text = "";
    }
}
