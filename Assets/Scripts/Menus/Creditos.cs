using UnityEngine;
using UnityEngine.UIElements;

public class CreditsScroller : MonoBehaviour
{
    public float speed = 200f; // Píxeles por segundo
    private VisualElement creditsTrack;
    private float currentY = 0f;

    void OnEnable()
    {
        // Obtener el documento de UI
        var root = GetComponent<UIDocument>().rootVisualElement;
        creditsTrack = root.Q<VisualElement>("Creditos");
        
        // Empezar desde el fondo de la pantalla
        currentY = Screen.height;
    }

    void Update()
    {
        if (creditsTrack != null)
        {
            // Mover hacia arriba
            currentY -= speed * Time.deltaTime;
            creditsTrack.style.top = currentY;

            // Opcional: Reiniciar o detener si ya pasaron todos los créditos
            if (currentY < -creditsTrack.layout.height * 2)
            {
                currentY = Screen.height;
            }
        }
    }
}