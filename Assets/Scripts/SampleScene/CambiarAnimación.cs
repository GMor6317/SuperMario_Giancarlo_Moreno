//Giancarlo Moreno Vázquez
using UnityEngine;
public class CambiarAnimación : MonoBehaviour
{
    //Declarando variables
    private Animator animator;
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private EstadoPersonaje estado;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();       //Obteniendo los componentes del personaje
        sr = GetComponent<SpriteRenderer>();
        estado = GetComponentInChildren<EstadoPersonaje>();
    }

    void Update()
    {

        float velocidadX = rb.linearVelocityX;  //Obteniendo la velocidad del personaje

        animator.SetFloat("velocidad", Mathf.Abs(velocidadX));  //Determinando si el personaje se mueve
        
        if(velocidadX > 0.1f)
        {
            sr.flipX = false;
        }
        else if(velocidadX < -0.1f)
        {
            sr.flipX = true;
        }

        animator.SetBool("enPiso", estado.estaEnPiso);  //Determinando si el personaje se encuentra en el suelo
    }
}
