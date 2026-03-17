using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoverConInputActions : MonoBehaviour
{
    [SerializeField]
    private InputAction accionMover; //en las 4 posiciones

    [SerializeField]
    private InputAction accionSaltar; //Saltar con el espacio

    private float velocidadX = 7f; //Definiendo la velocidad maxima que tendra en el eje X
    private float velocidadY = 12f;

    private EstadoPersonaje estado;

    private Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Habilitar el InputAction
        rb = GetComponent<Rigidbody2D>();
        estado = GetComponentInChildren<EstadoPersonaje>();
        
    }


    void OnEnable() //Si el objeto esta habilitado se pueda utilizar, si no no
    {
        accionMover.Enable();
        accionSaltar.Enable();
        accionSaltar.performed += saltar; //Se le dice al objeto que agregue en su lista de funciones la funcion saltar      
    }

    void OnDisable() //Si el objeto esta deshabilitado no se va a poder utilizar
    {
        accionSaltar.Disable();
        accionSaltar.performed -= saltar; //Se le dice al objeto que quite de su lista de funciones la funcion saltar      
        
    }

    public void saltar(InputAction.CallbackContext context) //Debe contener el parametro, si no no se reconoce
    {
        if (estado.estaEnPiso)
        {
            rb.linearVelocityY = velocidadY * 1; //Se cambia la velocidad en Y       
        }
        //Rigidbody2D rb = GetComponent<Rigidbody2D>(); //Se define rigidbody de manera local para poder hacer un salto
        
    }


    // Update is called once per frame
    void Update()
    {
        //Leer la entrada
        Vector2 movimiento = accionMover.ReadValue<Vector2>(); //Declaramos un vector que lea los valores del movimiento, es un Vector2 ya que solo tenemos x y
        //transform.position = (Vector2)transform.position + Time.deltaTime * movimiento * velocidadX;
        rb.linearVelocityX = velocidadX * movimiento.x;
    }
}
