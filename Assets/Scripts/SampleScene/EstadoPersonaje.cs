//Giancarlo Moreno Vázquez
using UnityEngine;

public class EstadoPersonaje : MonoBehaviour
{
     public bool estaEnPiso {get; private set;} = false;    //Variable para almacenar valor de si el personaje esta en piso o no

    void OnTriggerEnter2D(Collider2D collision) //Función que determina si el personaje está en el piso mediante una colisión
    {
        estaEnPiso = true;
        print(estaEnPiso);
    }

    void OnTriggerExit2D(Collider2D collision)  //Función que determina si el personaje abandona el piso mediante una colisión
    {
        estaEnPiso = false;
        print(estaEnPiso);     
    }
}
