using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Menu : MonoBehaviour
{
    private UIDocument menu;
    private Button botonJugar;
    private Button botonAyuda;
    private Button botonCreditos;

    void OnEnable()
    {
        menu = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;

        botonJugar = root.Q<Button>("BotonJugar");
        botonAyuda = root.Q<Button>("BotonAyuda");
        botonCreditos = root.Q<Button>("BotonCreditos");

        botonJugar.RegisterCallback<ClickEvent>(EmpiezaJuego);
        // botonAyuda.RegisterCallback<ClickEvent>(AbrirAyuda);
        // botonCreditos.RegisterCallback<ClickEvent>(AbrirCreditos);
    }
    private void EmpiezaJuego(ClickEvent evt)
    {
        SceneManager.LoadScene("SampleScene");
    }
}
