using UnityEngine;

public class Enemigo : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            MuerteJugador player = collision.GetComponent<MuerteJugador>();

            if(player != null)
            {
                player.Muerte();
            }
        }
    }
}
