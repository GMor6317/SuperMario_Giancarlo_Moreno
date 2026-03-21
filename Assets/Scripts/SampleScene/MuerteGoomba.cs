//Giancarlo Moreno Vázquez
using UnityEngine;

public class MuerteGoomba : MonoBehaviour
{
    //Declarando variables
    private Animator anim;
    private Rigidbody2D rb;
    private Collider2D coll;

    //nuevo
    public bool muerto = false;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();   //Obteniendo componentes del enemigo
        coll = GetComponent<Collider2D>();
    }

    public void Muerte()    //Función que simula la muerte del personaje por medio de una animación
    {
        //Verificando estado
        if (muerto)
        {
            return;
        }
        muerto = true;

        coll.enabled = false;   //Evitando que una vez muerto el enemigo pueda matar al personaje

        if (rb != null) //Si se detecta el RigidBody del personaje...
        {
            rb.simulated = false;   //Lo desactiva
        }

        anim.SetTrigger("Die"); //Ayuda a cambiar la animación del enemigo

        Destroy(gameObject, 0.5f);  //Desaparece al enemigo del mapa
    }
}
