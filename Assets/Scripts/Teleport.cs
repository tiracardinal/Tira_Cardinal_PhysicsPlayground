using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField] private Transform destination;

    [SerializeField] private float cooldownTime = 1.0f;

    private static float nextAllowedTeleportTime = 0f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && Time.time >= nextAllowedTeleportTime) 
        {
            nextAllowedTeleportTime = Time.time + cooldownTime;
            collision.transform.position = destination.position;
        }

    }
}
