using System;
using UnityEngine;

public class CambiarAnimación : MonoBehaviour
{

    private Animator animator;
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private EstadoPersonaje estado;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        estado = GetComponentInChildren<EstadoPersonaje>();
    }

    // Update is called once per frame
    void Update()
    {

        float velocidadX = rb.linearVelocityX;

        animator.SetFloat("velocidad", Mathf.Abs(velocidadX));
        
        if(velocidadX > 0.1f)
        {
            sr.flipX = false;
        }
        else if(velocidadX < -0.1f)
        {
            sr.flipX = true;
        }

        animator.SetBool("enPiso", estado.estaEnPiso);
    }
}
