using UnityEngine;
using UnityEngine.UIElements;

public class Creditos : MonoBehaviour
{
    private ScrollView scrollView;
    public float velocidad = 30f;

    void OnEnable()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        scrollView = root.Q<ScrollView>("ScrollCreditos");
    }
    void Update()
    {
        if (scrollView != null)
        {
            // Avanza el scroll poco a poco
            scrollView.verticalScroller.value += velocidad * Time.deltaTime;
        }
    }
}