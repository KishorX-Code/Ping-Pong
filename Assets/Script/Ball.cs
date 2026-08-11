using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameManager gameManager;
    public Rigidbody2D rb2d;
    public float maxInitailAngle = 0.67f;
    public float movespeed = 1f;
    private float startX = 0f;
    public float starty = 4f;
    public float speedMultipler = 1.1f;
    public AudioSource audioSource;
    public AudioClip ballsound;
    
   private void Start()
    {
        push();
        GameManager.instance.onReset += ResetBall;
        
    }
    private void ResetBall()
    {
        ResetBallPosition();
        push();
    }
    private void push()
        
    {
        
        Vector2 dir = Random.value < 0.5f ? Vector2.left : Vector2.right;
           
        dir.y = Random.Range(-maxInitailAngle, maxInitailAngle);
        rb2d.velocity = dir * movespeed;
    }
    
    private void ResetBallPosition()
    {
        float posY = Random.Range(-starty, starty);
        Vector2 position = new Vector2(startX, posY);
        transform.position = position;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Scorezone scorezone = collision.GetComponent<Scorezone>();
        if (scorezone)
        {
            GameManager.instance.OnScoreZoneReached(scorezone.id);
            
            
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        audioSource.PlayOneShot(ballsound);
        Paddle paddle = collision.collider.GetComponent<Paddle>();
        if (paddle)
        {
            rb2d.velocity *= speedMultipler;
        }
        
       
    }
}
