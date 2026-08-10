using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleAI : MonoBehaviour
{
    public Transform ball;
    public Rigidbody2D rb2d;
    public float movespeed = 3f;
   private void Update()
    {
        float movement = 0f;
        if(ball.position.y > transform.position.y)
        {
            movement = 1f;
        }
        else if(ball.position.y < transform.position.y)
        {
            movement = -1f;
        }
        Vector2 velo = rb2d. velocity;
        velo.y = movespeed * movement;
        rb2d.velocity = velo;

    }
}
