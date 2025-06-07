using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Controla un botón que reproduce un sonido al hacer clic 
/// y luego cambia de escena una vez finalizado el sonido.
/// </summary>
public class BotonConSonido : MonoBehaviour
{
    /// <summary>
    /// Nombre de la escena que se cargará después de hacer clic.
    /// </summary>
    public string nombreDeEscena;

    /// <summary>
    /// Clip de audio que se reproducirá al hacer clic.
    /// </summary>
    public AudioClip sonidoClick;

    /// <summary>
    /// Componente AudioSource utilizado para reproducir el sonido.
    /// </summary>
    private AudioSource audioSource;

    /// <summary>
    /// Bandera para evitar múltiples reproducciones y cambios de escena.
    /// </summary>
    private bool haReproducido = false;

    /// <summary>
    /// Inicializa el componente AudioSource al comenzar la escena.
    /// </summary>
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    /// <summary>
    /// Método que se ejecuta al hacer clic en el botón.
    /// Reproduce el sonido y espera a que termine para cambiar de escena.
    /// </summary>
    public void AlHacerClick()
    {
        if (!haReproducido)
        {
            audioSource.PlayOneShot(sonidoClick);
            haReproducido = true;
            Invoke("CambiarEscena", sonidoClick.length);
        }
    }

    /// <summary>
    /// Cambia a la escena especificada en 'nombreDeEscena'.
    /// </summary>
    void CambiarEscena()
    {
        SceneManager.LoadScene(nombreDeEscena);
    }
}
