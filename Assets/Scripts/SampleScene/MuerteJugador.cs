using UnityEngine;
using UnityEngine.SceneManagement;

public class MuerteJugador : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb;
    private Collider2D coll;

    public float deathJumpForce = 10f;
    private bool isDead = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<Collider2D>();
    }

    public void Muerte()
    {
        if (isDead)
        {
            return;
        }

        isDead = true;
        anim.SetTrigger("Die");

        if(coll != null)
        {
            coll.enabled = false;
        }

        rb.linearVelocity = Vector2.zero;
        rb.AddForce(Vector2.up * deathJumpForce, ForceMode2D.Impulse);
        
        

        Invoke("RestartLevel", 2.5f);
    }

    void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
