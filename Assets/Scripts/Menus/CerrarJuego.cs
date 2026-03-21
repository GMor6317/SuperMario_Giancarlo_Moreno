using UnityEngine;
using UnityEngine.UIElements;

public class CerrarJuego : MonoBehaviour
{
    private UIDocument menu;
    private Button MbotonCerrar;
    private Button AbotonCerrar;

    void OnEnable()
    {
        menu = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;

        MbotonCerrar = root.Q<Button>("BotonCerrarM");
        MbotonCerrar.clicked += CierreJuego;
        
        AbotonCerrar = root.Q<Button>("BotonCerrarA");
        AbotonCerrar.clicked += CierreJuego;
    }

    private void CierreJuego()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
