using UnityEngine;

public class MuerteGoomba : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb;
    private Collider2D coll;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<Collider2D>();
    }

    public void Muerte()
    {
        coll.enabled = false;

        if (rb != null)
        {
            rb.simulated = false;
        }

        anim.SetTrigger("Die");

        Destroy(gameObject, 0.5f);
    }
}
