using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// Gestiona la retroalimentación para una pregunta de verdadero/falso, reproduciendo sonidos,
/// mostrando paneles de retroalimentación y guardando puntajes.
/// </summary>
public class RetroalimentacionManager1 : MonoBehaviour
{
    /// <summary>Botón para la opción "Verdadero".</summary>
    public Button botonVerdadero;

    /// <summary>Botón para la opción "Falso".</summary>
    public Button botonFalso;

    /// <summary>Panel que se muestra cuando la respuesta es correcta.</summary>
    public GameObject panelRetroBuena;

    /// <summary>Panel que se muestra cuando la respuesta es incorrecta.</summary>
    public GameObject panelRetroMala;

    /// <summary>Botón para continuar después de una respuesta correcta.</summary>
    public Button botonSiguienteBuena;

    /// <summary>Botón para continuar después de una respuesta incorrecta.</summary>
    public Button botonSiguienteMala;

    /// <summary>Componente AudioSource para reproducir sonidos.</summary>
    public AudioSource audioSource;

    /// <summary>Sonido para la respuesta "Verdadero".</summary>
    public AudioClip sonidoVerdadero;

    /// <summary>Sonido para la respuesta "Falso".</summary>
    public AudioClip sonidoFalso;

    /// <summary>Nombre de la siguiente escena a cargar.</summary>
    public string nombreSiguienteEscena;

    /// <summary>Clave para guardar el puntaje en PlayerPrefs (ejemplo: "PuntosActividad1").</summary>
    public string clavePuntaje = "PuntosActividad1";

    /// <summary>
    /// Inicializa los botones y paneles, asignando eventos y ocultando retroalimentaciones al inicio.
    /// </summary>
    void Start()
    {
        panelRetroBuena.SetActive(false);
        panelRetroMala.SetActive(false);

        botonVerdadero.onClick.AddListener(() => {
            ReproducirSonido(sonidoVerdadero);
            GuardarPuntaje(100); // Puntaje máximo si acierta
            MostrarRetroBuena();
        });

        botonFalso.onClick.AddListener(() => {
            ReproducirSonido(sonidoFalso);
            GuardarPuntaje(0); // Puntaje 0 si falla
            MostrarRetroMala();
        });

        botonSiguienteBuena.onClick.AddListener(CargarSiguienteEscena);
        botonSiguienteMala.onClick.AddListener(CargarSiguienteEscena);
    }

    /// <summary>
    /// Guarda el puntaje en PlayerPrefs con la clave especificada.
    /// </summary>
    /// <param name="puntos">Puntaje a guardar.</param>
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
    /// Reproduce un clip de audio si está asignado.
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
    /// Carga la siguiente escena según el nombre asignado.
    /// </summary>
    void CargarSiguienteEscena()
    {
        SceneManager.LoadScene(nombreSiguienteEscena);
    }
}
