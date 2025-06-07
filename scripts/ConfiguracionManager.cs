using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Controla el panel de configuración, permitiendo activar o desactivar la música.
/// El estado se guarda usando PlayerPrefs.
/// </summary>
public class ConfiguracionManager : MonoBehaviour
{
    /// <summary>
    /// Panel que contiene las opciones de configuración.
    /// </summary>
    public GameObject panelConfiguracion;

    /// <summary>
    /// Toggle para activar o desactivar la música.
    /// </summary>
    public Toggle toggleMusica;

    /// <summary>
    /// Botón para abrir o cerrar el panel de configuración.
    /// </summary>
    public Button botonConfiguracion;

    /// <summary>
    /// Fuente de audio de la música del menú.
    /// </summary>
    public AudioSource musicaMenu;

    /// <summary>
    /// Fuente de audio de la música de la actividad 1.
    /// </summary>
    public AudioSource musicaActividad1;

    /// <summary>
    /// Fuente de audio de la música de la actividad 2.
    /// </summary>
    public AudioSource musicaActividad2;

    /// <summary>
    /// Inicializa el panel y sincroniza el estado del toggle con PlayerPrefs.
    /// </summary>
    void Start()
    {
        panelConfiguracion.SetActive(false);

        bool musicaActiva = PlayerPrefs.GetInt("MusicaActiva", 1) == 1;
        toggleMusica.isOn = musicaActiva;

        AplicarEstadoMusica(musicaActiva);

        botonConfiguracion.onClick.AddListener(TogglePanelConfiguracion);
        toggleMusica.onValueChanged.AddListener(OnToggleMusica);
    }

    /// <summary>
    /// Abre o cierra el panel de configuración y sincroniza el toggle si se vuelve a abrir.
    /// </summary>
    void TogglePanelConfiguracion()
    {
        bool estaActivo = panelConfiguracion.activeSelf;
        panelConfiguracion.SetActive(!estaActivo);

        if (!estaActivo)
        {
            bool musicaActiva = PlayerPrefs.GetInt("MusicaActiva", 1) == 1;
            toggleMusica.isOn = musicaActiva;
        }
    }

    /// <summary>
    /// Se ejecuta cuando el usuario cambia el estado del toggle.
    /// Actualiza el estado de la música y lo guarda en PlayerPrefs.
    /// </summary>
    /// <param name="estaActiva">Indica si la música debe estar activa o no.</param>
    void OnToggleMusica(bool estaActiva)
    {
        AplicarEstadoMusica(estaActiva);

        PlayerPrefs.SetInt("MusicaActiva", estaActiva ? 1 : 0);
        PlayerPrefs.Save();
    }

    /// <summary>
    /// Aplica el estado de activación o desactivación a todas las fuentes de música.
    /// </summary>
    /// <param name="activa">Si es verdadero, la música se activa; si es falso, se silencia.</param>
    void AplicarEstadoMusica(bool activa)
    {
        if (musicaMenu != null) musicaMenu.mute = !activa;
        if (musicaActividad1 != null) musicaActividad1.mute = !activa;
        if (musicaActividad2 != null) musicaActividad2.mute = !activa;
    }
}
