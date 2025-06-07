using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Permite cambiar a una escena específica al llamar al método desde un botón u otro evento.
/// </summary>
public class CambiarEscenaSiguiente : MonoBehaviour
{
    /// <summary>
    /// Nombre de la escena a la que se desea cambiar.
    /// </summary>
    public string nombreEscenaSiguiente;

    /// <summary>
    /// Método público que carga la escena indicada en 'nombreEscenaSiguiente'.
    /// Puede ser llamado desde un botón o cualquier otro evento.
    /// </summary>
    public void IrANivelSiguiente()
    {
        SceneManager.LoadScene(nombreEscenaSiguiente);
    }
}
