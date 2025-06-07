using UnityEngine;
using UnityEngine.SceneManagement;  // Necesario para manejar las escenas

/// <summary>
/// Permite cambiar a la escena de la actividad cuando se llama al método correspondiente.
/// </summary>
public class CambiarEscena : MonoBehaviour
{
    /// <summary>
    /// Carga la escena "Nivelcar1", que corresponde a la actividad después de la isla 1.
    /// </summary>
    public void IrAActividad()
    {
        SceneManager.LoadScene("Nivelcar1");  // Sustituye "Nivelcar1" por el nombre real de tu escena
    }
}
