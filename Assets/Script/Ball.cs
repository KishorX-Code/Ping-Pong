using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float maxInitailAngle = 0.67f;
   private void Start()
    {
        Vector2 dir = Vector2.left;
        dir.y = Random.Range(maxInitailAngle, maxInitailAngle);
        rb2d.velocity = dir;
    }

    
    void Update()
    {
        
    }
}
