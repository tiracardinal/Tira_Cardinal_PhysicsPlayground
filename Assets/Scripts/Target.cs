using System.Collections;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] SpriteRenderer rend;
    [SerializeField] CircleCollider2D collide;

    [SerializeField] bool autoReset;
    [SerializeField] float resetTime;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rend.color = Color.gray;
        collide.enabled = false;

        if (autoReset)
        {
            Invoke("DelayReset", resetTime);
        }
    }

    public void ResetTarget(float resetTime)
    {
        Invoke("DelayReset", resetTime);
    }

    public bool IsTargetActive()
    {
        return collide.enabled;
    }

    void DelayReset()
    {
        rend.color = Color.yellow;
        collide.enabled = true;
    }
}
