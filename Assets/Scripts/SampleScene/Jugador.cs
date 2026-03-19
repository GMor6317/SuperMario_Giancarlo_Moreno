using UnityEngine;

public class Jugador : MonoBehaviour
{

    public float bounceForce = 12f;
    private Rigidbody2D playerRb;

    void Start()
    {
        playerRb = GetComponentInParent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            MuerteGoomba enemy = collision.GetComponent<MuerteGoomba>();

            if(enemy != null)
            {
                enemy.Muerte();
                playerRb.linearVelocity = new Vector2(playerRb.linearVelocityX, bounceForce);
            }
        }
    }
}
