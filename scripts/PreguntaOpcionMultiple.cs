using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// <summary>
/// Controla la lógica de una pregunta de opción múltiple con retroalimentación visual y sonora.
/// </summary>
public class PreguntaOpcionMultiple : MonoBehaviour
{
    // Botones de opciones
    public Button botonOpcion1; // Correcto
    public Button botonOpcion2; // Correcto
    public Button botonOpcion3; // Incorrecto

    // Paneles de retroalimentación
    public GameObject panelRetroOpcion1; // Correcto
    public GameObject panelRetroOpcion2; // Correcto
    public GameObject panelRetroOpcion3; // Incorrecto

    // Botones "Siguiente" en cada panel
    public Button botonSiguiente1;
    public Button botonSiguiente2;
    public Button botonSiguiente3;

    // Sonidos
    public AudioClip sonidoCorrecto1;
    public AudioClip sonidoCorrecto2;
    public AudioClip sonidoIncorrecto;

    private AudioSource audioSource;

    /// <summary>
    /// Inicializa el script, asigna los eventos a los botones y oculta los paneles de retroalimentación.
    /// </summary>
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        // Asignar eventos a los botones de opciones
        botonOpcion1.onClick.AddListener(() => MostrarRetroalimentacion(panelRetroOpcion1, sonidoCorrecto1));
        botonOpcion2.onClick.AddListener(() => MostrarRetroalimentacion(panelRetroOpcion2, sonidoCorrecto2));
        botonOpcion3.onClick.AddListener(() => MostrarRetroalimentacion(panelRetroOpcion3, sonidoIncorrecto));

        // Asignar eventos a los botones "Siguiente"
        botonSiguiente1.onClick.AddListener(IrASiguienteEscena);
        botonSiguiente2.onClick.AddListener(IrASiguienteEscena);
        botonSiguiente3.onClick.AddListener(IrASiguienteEscena);

        // Ocultar todos los paneles al inicio
        panelRetroOpcion1.SetActive(false);
        panelRetroOpcion2.SetActive(false);
        panelRetroOpcion3.SetActive(false);
    }

    /// <summary>
    /// Muestra el panel de retroalimentación correspondiente y reproduce el sonido asociado.
    /// Además, desactiva los botones de opciones para evitar múltiples respuestas.
    /// </summary>
    /// <param name="panelRetro">Panel de retroalimentación a mostrar.</param>
    /// <param name="sonido">Clip de audio que se reproducirá.</param>
    private void MostrarRetroalimentacion(GameObject panelRetro, AudioClip sonido)
    {
        audioSource.PlayOneShot(sonido);
        panelRetro.SetActive(true);

        botonOpcion1.interactable = false;
        botonOpcion2.interactable = false;
        botonOpcion3.interactable = false;
    }

    /// <summary>
    /// Carga la siguiente escena en la lista de Build Settings si existe.
    /// </summary>
    public void IrASiguienteEscena()
    {
        int siguienteEscena = SceneManager.GetActiveScene().buildIndex + 1;
        if (siguienteEscena < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(siguienteEscena);
        }
        else
        {
            Debug.LogWarning("No hay más escenas en la lista.");
        }
    }
}
