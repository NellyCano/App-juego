using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// Controla una barra de progreso que avanza automáticamente
/// y cambia de escena al completarse.
/// </summary>
public class Barraprogreso2 : MonoBehaviour
{
    /// <summary>
    /// Referencia al componente Slider que representa la barra de progreso.
    /// </summary>
    public Slider Barra;

    /// <summary>
    /// Texto que muestra el valor actual del progreso en porcentaje.
    /// </summary>
    public Text ValorString;

    /// <summary>
    /// Duración total de la carga (en segundos).
    /// </summary>
    public float duracion = 2f;

    /// <summary>
    /// Tiempo actual transcurrido desde el inicio de la barra.
    /// </summary>
    private float tiempoActual = 0f;

    /// <summary>
    /// Actualiza la barra de progreso en cada frame.
    /// </summary>
    void Update()
    {
        if (tiempoActual < duracion)
        {
            tiempoActual += Time.deltaTime * 5f; // Avanza 5 veces más rápido
            float porcentaje = tiempoActual / duracion;
            Barra.value = porcentaje;
            ValorString.text = (porcentaje * 100f).ToString("F0") + "%";
        }
        else
        {
            CambiarEscena();
        }
    }

    /// <summary>
    /// Cambia a la escena llamada "Interfaz" una vez que la barra se completa.
    /// </summary>
    void CambiarEscena()
    {
        SceneManager.LoadScene("Nivelcar1");
    }
}
