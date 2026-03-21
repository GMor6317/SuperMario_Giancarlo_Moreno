//Giancarlo Moreno Vázquez
using UnityEngine;

public class DetectarAplastado : MonoBehaviour
{
    private MuerteGoomba goomba;
    void Start()
    {
        goomba = GetComponentInParent<MuerteGoomba>();
    }

    private void OnTriggerEnter2D(Collider2D collision) //Función que determina si el goomba muere
    {
        if (collision.CompareTag("Player")) //Verificando colisión con el jugador
        {
            Rigidbody2D rbPlayer = collision.GetComponent<Rigidbody2D>();
            if(rbPlayer.linearVelocityY < 0)
            {
                goomba.Muerte();  //Simulando muerte del goomba
                rbPlayer.linearVelocity = new Vector2(rbPlayer.linearVelocity.x, 12f);  //Añadiendo impulso al personaje tras alastar enemigo
            }   
        }
    }
}
