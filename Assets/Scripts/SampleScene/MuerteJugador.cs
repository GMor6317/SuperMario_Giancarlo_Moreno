//Giancarlo Moreno Vázquez
using UnityEngine;
using UnityEngine.SceneManagement;

public class MuerteJugador : MonoBehaviour
{   
    //Declarando variables
    private Animator anim;
    private Rigidbody2D rb;
    private Collider2D coll;

    public float deathJumpForce = 10f;  //Variable que controla la fuerza de salto del personaje al morir
    private bool isDead = false;    //Declarando estado del personaje
    
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();   //Obteniendo los componentes del personaje
        coll = GetComponent<Collider2D>();
    }

    public void Muerte()    //Función que simula la muerte del personaje por medio de una animación
    {
        if (isDead) //Si esta muerto, regresa
        {
            return; 
        }

        isDead = true;  //Cambiando estado del personaje
        anim.SetTrigger("Die"); //Ayuda a cambiar la animación del personaje

        if(coll != null)    //Control del collider para simular la muerte de Mario
        {
            coll.enabled = false;   //Desactivando collider 
        }

        rb.linearVelocity = Vector2.zero;   //Cambiando la velocidad a 0
        rb.AddForce(Vector2.up * deathJumpForce, ForceMode2D.Impulse);  //Si el personaje muere, se impulsa hacia arriba y cae

        Invoke("RestartLevel", 2.5f);   //Reiniciando el nivel
    }

    void RestartLevel() //Función para reiniciar el nivel
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
