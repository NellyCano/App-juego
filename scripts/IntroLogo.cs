using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Controla la introducción con logo, esperando un tiempo definido antes de cambiar a la siguiente escena.
/// </summary>
public class IntroLogo : MonoBehaviour
{
    /// <summary>
    /// Tiempo de espera en segundos antes de pasar a la siguiente escena.
    /// </summary>
    public float tiempoEspera = 20f;

    /// <summary>
    /// Nombre de la siguiente escena que se cargará después del tiempo de espera.
    /// </summary>
    public string siguienteEscena = "PantallaCarga";

    /// <summary>
    /// Inicia la cuenta regresiva para cambiar de escena automáticamente.
    /// </summary>
    void Start()
    {
        Invoke("CargarSiguienteEscena", tiempoEspera);
    }

    /// <summary>
    /// Carga la escena definida en 'siguienteEscena'.
    /// </summary>
    void CargarSiguienteEscena()
    {
        SceneManager.LoadScene(siguienteEscena);
    }
}
