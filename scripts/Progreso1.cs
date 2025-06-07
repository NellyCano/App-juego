using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// Controla una barra de progreso que se llena durante un tiempo determinado y luego carga una escena.
/// </summary>
public class Progreso1 : MonoBehaviour
{
    /// <summary>
    /// Slider que representa visualmente la barra de progreso.
    /// </summary>
    public Slider Barra;

    /// <summary>
    /// Texto que muestra el porcentaje de progreso en formato string.
    /// </summary>
    public Text ValorString;

    /// <summary>
    /// Duración total en segundos para llenar la barra.
    /// </summary>
    public float duracion = 2f;

    /// <summary>
    /// Tiempo acumulado desde que empezó el progreso.
    /// </summary>
    private float tiempoActual = 0f;

    /// <summary>
    /// Actualiza la barra de progreso y el texto cada frame.
    /// Cuando el progreso termina, cambia a la escena "Nivelcar1".
    /// </summary>
    void Update()
    {
        if (tiempoActual < duracion)
        {
            tiempoActual += Time.deltaTime * 5f;
            float porcentaje = tiempoActual / duracion;
            Barra.value = porcentaje;
            ValorString.text = (porcentaje * 100f).ToString("F0") + "%";
        }
        else
        {
            SceneManager.LoadScene("Nivelcar1");
        }
    }
}
