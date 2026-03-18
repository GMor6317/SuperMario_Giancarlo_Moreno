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
    private Button botonCerrarAyuda;
    private Button botonCerrarCreditos;
    private Button cerrarAyuda;

    private VisualElement panelMenu;
    private VisualElement panelAyuda;
    private VisualElement panelCreditos;

    void OnEnable()
    {
        menu = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;

        //Botones de menu principal
        botonJugar = root.Q<Button>("BotonJugar");
        botonAyuda = root.Q<Button>("BotonAyuda");
        botonCreditos = root.Q<Button>("BotonCreditos");

        //Botones de cerrar pestaña
        cerrarAyuda = root.Q<Button>("CerrarAyuda");
        botonCerrarAyuda = root.Q<Button>("CerrarAyuda");
        botonCerrarCreditos = root.Q<Button>("CerrarCreditos");

        //Paneles
        panelMenu = root.Q<VisualElement>("Menu");
        panelAyuda = root.Q<VisualElement>("MenuAyuda");
        panelCreditos = root.Q<VisualElement>("MenuCreditos");

        //Acciones
        //botonJugar.RegisterCallback<ClickEvent>(EmpiezaJuego);
        botonJugar.clicked += EmpiezaJuego;
        botonAyuda.clicked += () => MostrarPanel(panelAyuda);
        botonCreditos.clicked += () => MostrarPanel(panelCreditos);

        botonCerrarAyuda.clicked += VolverAlMenu;
        botonCerrarCreditos.clicked += VolverAlMenu;
        cerrarAyuda.clicked += VolverAlMenu;
        
    }

    private void EmpiezaJuego()
    {
        SceneManager.LoadScene("SampleScene");
    }

    private void MostrarPanel(VisualElement panel)
    {
        panelMenu.style.display = DisplayStyle.None;
        panel.style.display = DisplayStyle.Flex;
    }

    private void VolverAlMenu()
    {
        panelAyuda.style.display = DisplayStyle.None;
        panelCreditos.style.display = DisplayStyle.None;
        panelMenu.style.display = DisplayStyle.Flex;
    }
}
