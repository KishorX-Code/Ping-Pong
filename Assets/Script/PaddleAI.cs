using UnityEngine;

public class PaddleAI : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public Transform ball;
    public float movespeed = 5f;
    public float deadZone = 0.05f;

    private void FixedUpdate()
    {
        if (ball == null || rb2d == null)
            return;

        float difference = ball.position.y - rb2d.position.y;

        float direction = 0f;

        if (Mathf.Abs(difference) > deadZone)
        {
            direction = Mathf.Sign(difference);
        }

        Vector2 targetPosition = rb2d.position;
        targetPosition.y += direction * movespeed * Time.fixedDeltaTime;

        rb2d.MovePosition(targetPosition);
    }
}
