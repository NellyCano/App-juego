using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// Muestra el puntaje total acumulado de las actividades y permite avanzar a la siguiente escena.
/// </summary>
public class MostrarPuntosTotales2 : MonoBehaviour
{
    /// <summary>
    /// Texto UI que muestra los puntos totales.
    /// </summary>
    public Text textoPuntosTotales;

    /// <summary>
    /// Botón para continuar a la siguiente escena.
    /// </summary>
    public Button botonContinuar;

    /// <summary>
    /// Slider visual que representa el progreso en puntos.
    /// </summary>
    public Slider sliderProgreso;

    /// <summary>
    /// Puntos máximos posibles para la suma total.
    /// </summary>
    private int puntosMaximos = 200;

    /// <summary>
    /// Inicializa el texto, slider y asigna la función al botón continuar.
    /// </summary>
    void Start()
    {
        int puntos1 = PlayerPrefs.GetInt("PuntosActividad1", 0);
        int puntos2 = PlayerPrefs.GetInt("PuntosActividad2", 0);
        int total = puntos1 + puntos2;

        textoPuntosTotales.text = $"¡Puntos totales: {total} / {puntosMaximos}!";

        sliderProgreso.maxValue = puntosMaximos;
        sliderProgreso.value = total;

        botonContinuar.onClick.AddListener(CambiarEscena);
    }

    /// <summary>
    /// Cambia a la escena del siguiente nivel.
    /// </summary>
    void CambiarEscena()
    {
        SceneManager.LoadScene("Nivel 2 Nieve");
    }
}
