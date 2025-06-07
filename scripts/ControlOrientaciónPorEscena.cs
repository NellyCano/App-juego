using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Controla la orientación de la pantalla dependiendo de la escena actual.
/// Algunas escenas se fuerzan en orientación vertical y otras en horizontal.
/// </summary>
public class ControlOrientacionPorEscena : MonoBehaviour
{
    /// <summary>
    /// En el inicio, verifica el nombre de la escena activa y ajusta la orientación de la pantalla.
    /// </summary>
    void Start()
    {
        string escenaActual = SceneManager.GetActiveScene().name;

        // Escenas que deben mostrarse en orientación vertical
        if (escenaActual == "Pantalla de inicio 1" || escenaActual == "pantallacarga")
        {
            Screen.orientation = ScreenOrientation.Portrait;

            // Solo permitir orientación vertical
            Screen.autorotateToPortrait = true;
            Screen.autorotateToPortraitUpsideDown = true;
            Screen.autorotateToLandscapeLeft = false;
            Screen.autorotateToLandscapeRight = false;
        }
        else
        {
            Screen.orientation = ScreenOrientation.LandscapeLeft;

            // Solo permitir orientación horizontal
            Screen.autorotateToLandscapeLeft = true;
            Screen.autorotateToLandscapeRight = true;
            Screen.autorotateToPortrait = false;
            Screen.autorotateToPortraitUpsideDown = false;
        }
    }
}
