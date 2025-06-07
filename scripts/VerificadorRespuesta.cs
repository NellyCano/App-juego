using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

/// <summary>
/// Verifica la respuesta ingresada por el usuario en un campo de texto,
/// muestra retroalimentación visual y sonora, guarda el puntaje y permite avanzar a la siguiente escena.
/// </summary>
public class VerificadorRespuesta : MonoBehaviour
{
    /// <summary>Campo de entrada para la respuesta del usuario.</summary>
    public TMP_InputField inputRespuesta;

    /// <summary>Botón para verificar la respuesta ingresada.</summary>
    public Button botonVerificar;

    /// <summary>Panel que muestra retroalimentación positiva.</summary>
    public GameObject panelRetroBuena;

    /// <summary>Panel que muestra retroalimentación negativa.</summary>
    public GameObject panelRetroMala;

    /// <summary>Botón para avanzar tras retroalimentación positiva.</summary>
    public Button botonSiguienteBuena;

    /// <summary>Botón para avanzar tras retroalimentación negativa.</summary>
    public Button botonSiguienteMala;

    /// <summary>Respuesta correcta esperada (sin diferenciar mayúsculas/minúsculas).</summary>
    public string respuestaCorrecta = "interrogativa";

    /// <summary>Nombre de la escena siguiente a cargar.</summary>
    public string nombreSiguienteEscena;

    /// <summary>Componente AudioSource para reproducir sonidos.</summary>
    public AudioSource audioSource;

    /// <summary>Sonido que se reproduce si la respuesta es correcta.</summary>
    public AudioClip sonidoCorrecto;

    /// <summary>Sonido que se reproduce si la respuesta es incorrecta.</summary>
    public AudioClip sonidoIncorrecto;

    /// <summary>
    /// Inicializa el estado de los paneles y asigna eventos a los botones.
    /// </summary>
    void Start()
    {
        panelRetroBuena.SetActive(false);
        panelRetroMala.SetActive(false);

        botonVerificar.onClick.AddListener(Verificar);
        botonSiguienteBuena.onClick.AddListener(CargarSiguienteEscena);
        botonSiguienteMala.onClick.AddListener(CargarSiguienteEscena);
    }

    /// <summary>
    /// Verifica si la respuesta ingresada coincide con la correcta,
    /// muestra la retroalimentación correspondiente y guarda el puntaje.
    /// </summary>
    void Verificar()
    {
        string respuestaUsuario = inputRespuesta.text.Trim().ToLower();

        if (respuestaUsuario == respuestaCorrecta.ToLower())
        {
            panelRetroBuena.SetActive(true);
            panelRetroMala.SetActive(false);
            ReproducirSonido(sonidoCorrecto);

            // Guarda 100 puntos si la respuesta es correcta
            PlayerPrefs.SetInt("PuntosActividad1", 100);
        }
        else
        {
            panelRetroBuena.SetActive(false);
            panelRetroMala.SetActive(true);
            ReproducirSonido(sonidoIncorrecto);

            // Guarda 0 puntos si la respuesta es incorrecta
            PlayerPrefs.SetInt("PuntosActividad1", 0);
        }
    }

    /// <summary>
    /// Reproduce un clip de audio si está disponible.
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
    /// Carga la escena definida en el inspector.
    /// </summary>
    void CargarSiguienteEscena()
    {
        SceneManager.LoadScene(nombreSiguienteEscena);
    }
}
