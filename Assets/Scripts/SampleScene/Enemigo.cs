//Giancarlo Moreno Vázquez
using System.Runtime.CompilerServices;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    private MuerteGoomba muerteGoomba;

    void Start()
    {
        muerteGoomba = GetComponent<MuerteGoomba>();
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (muerteGoomba.muerto)
        {
            return;
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            MuerteJugador player = collision.gameObject.GetComponent<MuerteJugador>();
            if(player != null)
            {
                player.Muerte();
            }
        }
    }
}


