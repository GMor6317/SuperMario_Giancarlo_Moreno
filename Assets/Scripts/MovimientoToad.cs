using UnityEngine;

public class MovimientoToad : MonoBehaviour
{
    public float velocidadX = 2f;
    public Rigidbody2D rb;
    public Transform posicion;
    public float xMin = -9.2f;
    public float xMax = 2.0f;
    private bool movimientoDerecha = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (movimientoDerecha)
        {
            rb.linearVelocity = new Vector2(velocidadX, rb.linearVelocityY); 
            if (posicion.position.x >= xMax)
            {
                movimientoDerecha = false;
            }   
        }
        else
        {
            rb.linearVelocity = new Vector2(-velocidadX, rb.linearVelocityY);
            if (posicion.position.x <= xMin)
            {
                movimientoDerecha = true;
            }
        }
    }
}
