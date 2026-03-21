//Giancarlo Moreno Vázquez
using UnityEngine;
using Unity.Cinemachine;

public class CambioPantalla : MonoBehaviour
{
    //Declarando las pantallas del juego
    public CinemachineCamera camActual;
    public CinemachineCamera camSiguiente;

    private bool activado = false;  //Variable que determina si el collider está activo

    private void OnTriggerEnter2D(Collider2D other) //Función para realizar el cambio de pantalla a partir del collider
    {
        if (!activado && other.CompareTag("Player"))
        {
            camActual.Priority = 0;
            camSiguiente.Priority = 10;
            activado = true;
        }
    }
}
