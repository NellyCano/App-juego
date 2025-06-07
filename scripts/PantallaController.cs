using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Controla la carga de escenas y mantiene persistencia del objeto entre escenas.
/// </summary>
public class PantallaController : MonoBehaviour
{
    // Hace que este GameObject no se destruya al cargar una nueva escena
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    /// <summary>
    /// Carga una escena específica según su nombre.
    /// </summary>
    /// <param name="nombreEscena">Nombre de la escena a cargar.</param>
    public void CargarEscena(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }

    /// <summary>
    /// Carga la escena de la pantalla de inicio.
    /// </summary>
    public void CargarPantallaInicio()
    {
        SceneManager.LoadScene("Pantalla de Inicio");
    }

    /// <summary>
    /// Carga la escena de nivel 1 (la primera isla).
    /// </summary>
    public void CargarNivel1()
    {
        SceneManager.LoadScene("Niveles");
    }

    /// <summary>
    /// Carga la actividad correspondiente al nivel 1.
    /// </summary>
    public void CargarActividadNivel1()
    {
        SceneManager.LoadScene("Nivel 1 Actividad");
    }

    /// <summary>
    /// Carga la escena de retroalimentación.
    /// </summary>
    public void CargarRetroalimentacion()
    {
        SceneManager.LoadScene("Retroalimentación");
    }
}
