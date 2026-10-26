using UnityEngine;

public class BumperController : MonoBehaviour
{
    public BumperManager manager;
    public bool isActive;

    public PhysicsMaterial2D bouncyMaterial;

    private SpriteRenderer myRenderer;
    private Collider2D myCollider;

    void Awake()
    {
        myRenderer = GetComponent<SpriteRenderer>();
        myCollider = GetComponentInChildren<Collider2D>();
    }

    public void UpdateVisualsAndPhysics()
    {
        if (isActive)
        {
            myRenderer.color = Color.green;

            if (myCollider != null)
            {
                myCollider.sharedMaterial = bouncyMaterial;
            }
        }
        else
        {
            myRenderer.color = Color.gray;

            if (myCollider != null)
            {
                myCollider.sharedMaterial = null;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (manager != null)
            {
                manager.SwitchBumpers();
            }
        }
    }
}