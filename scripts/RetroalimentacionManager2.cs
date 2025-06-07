using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// Controla la retroalimentación para preguntas de verdadero/falso en la segunda actividad,
/// incluyendo reproducción de sonidos, manejo de paneles y guardado de puntajes.
/// </summary>
public class RetroalimentacionManager2 : MonoBehaviour
{
    /// <summary>Botón para la opción "Verdadero".</summary>
    public Button botonVerdadero;

    /// <summary>Botón para la opción "Falso".</summary>
    public Button botonFalso;

    /// <summary>Panel que muestra retroalimentación positiva.</summary>
    public GameObject panelRetroBuena;

    /// <summary>Panel que muestra retroalimentación negativa.</summary>
    public GameObject panelRetroMala;

    /// <summary>Botón para avanzar tras retroalimentación positiva.</summary>
    public Button botonSiguienteBuena;

    /// <summary>Botón para avanzar tras retroalimentación negativa.</summary>
    public Button botonSiguienteMala;

    /// <summary>Componente AudioSource para reproducir sonidos.</summary>
    public AudioSource audioSource;

    /// <summary>Sonido que se reproduce si la respuesta es verdadera.</summary>
    public AudioClip sonidoVerdadero;

    /// <summary>Sonido que se reproduce si la respuesta es falsa.</summary>
    public AudioClip sonidoFalso;

    /// <summary>Nombre de la escena siguiente a cargar.</summary>
    public string nombreSiguienteEscena;

    /// <summary>Clave para almacenar puntaje en PlayerPrefs.</summary>
    public string clavePuntaje = "PuntosActividad2";

    /// <summary>
    /// Inicializa los botones y oculta los paneles de retroalimentación.
    /// </summary>
    void Start()
    {
        panelRetroBuena.SetActive(false);
        panelRetroMala.SetActive(false);

        botonVerdadero.onClick.AddListener(() => {
            ReproducirSonido(sonidoVerdadero);
            GuardarPuntaje(100);
            MostrarRetroBuena();
        });

        botonFalso.onClick.AddListener(() => {
            ReproducirSonido(sonidoFalso);
            GuardarPuntaje(0);
            MostrarRetroMala();
        });

        botonSiguienteBuena.onClick.AddListener(CargarSiguienteEscena);
        botonSiguienteMala.onClick.AddListener(CargarSiguienteEscena);
    }

    /// <summary>
    /// Guarda el puntaje en PlayerPrefs bajo la clave especificada.
    /// </summary>
    /// <param name="puntos">Cantidad de puntos a guardar.</param>
    void GuardarPuntaje(int puntos)
    {
        PlayerPrefs.SetInt(clavePuntaje, puntos);
        PlayerPrefs.Save();
    }

    /// <summary>
    /// Muestra el panel de retroalimentación positiva y oculta el negativo.
    /// </summary>
    void MostrarRetroBuena()
    {
        panelRetroBuena.SetActive(true);
        panelRetroMala.SetActive(false);
    }

    /// <summary>
    /// Muestra el panel de retroalimentación negativa y oculta el positivo.
    /// </summary>
    void MostrarRetroMala()
    {
        panelRetroMala.SetActive(true);
        panelRetroBuena.SetActive(false);
    }

    /// <summary>
    /// Reproduce un clip de audio si es válido.
    /// </summary>
    /// <param name="clip">Clip de audio a reproducir.</param>
    void ReproducirSonido(AudioClip clip)
    {
        if (audioSource != null && clip != null)
        {
            audioSource.PlayOneShot(clip);
        }
    }

    /// <summary>
    /// Carga la siguiente escena definida en el inspector.
    /// </summary>
    void CargarSiguienteEscena()
    {
        SceneManager.LoadScene(nombreSiguienteEscena);
    }
}
