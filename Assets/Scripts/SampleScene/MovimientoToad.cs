//Giancarlo Moreno Vázquez
using UnityEngine;

public class MovimientoToad : MonoBehaviour
{
    //Declarando variables
    public Rigidbody2D rb;
    public float velocidadX = 2f;   
    public float xMin = -9.2f;
    public float xMax = 2.0f;
    private bool movimientoDerecha = true;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   //Obteniendo componentes del personaje
    }

    
    void Update()
    {
        //Controlando el movimiento horizontal del enemigo
        if (movimientoDerecha)
        {
            rb.linearVelocity = new Vector2(velocidadX, rb.linearVelocityY);    
            if (transform.position.x >= xMax)    //Delimitando hasta donde puede moverse el enemigo
            {
                movimientoDerecha = false;  //Cambiando de lado
            }   
        }
        else
        {
            rb.linearVelocity = new Vector2(-velocidadX, rb.linearVelocityY);
            if (transform.position.x <= xMin)    //Delimitando hasta donde puede moverse el enemigo
            {
                movimientoDerecha = true;   //Regresando al movimiento original
            }
        }
    }
}
