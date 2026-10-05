using System.Collections;
using UnityEngine;

public class FreezeField : MonoBehaviour
{
    Rigidbody2D ball;
    float freezeTime;
    [SerializeField] float delayTime;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ball = collision.gameObject.GetComponentInParent<Rigidbody2D>();
        if (ball != null)
        {
            ball.constraints = RigidbodyConstraints2D.FreezeAll;
            StartCoroutine(ballDelay(ball));
        }
    }

    IEnumerator ballDelay(Rigidbody2D ball)
    {
        yield return new WaitForSeconds(delayTime);
        if (ball != null)
        {
            ball.constraints = RigidbodyConstraints2D.None;
        }
    }
}