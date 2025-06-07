using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// Gestiona el formulario de ingreso de nombre y apellido del usuario.
/// Verifica que los campos estén completos antes de guardar y cambiar de escena.
/// </summary>
public class FormularioUsuario : MonoBehaviour
{
    /// <summary>
    /// Campo de entrada para el nombre del usuario.
    /// </summary>
    public InputField inputNombre;

    /// <summary>
    /// Campo de entrada para el apellido del usuario.
    /// </summary>
    public InputField inputApellido;

    /// <summary>
    /// Se ejecuta al presionar el botón de enviar.
    /// Verifica que ambos campos estén llenos, guarda los datos y cambia de escena.
    /// </summary>
    public void Enviar()
    {
        string nombre = inputNombre.text;
        string apellido = inputApellido.text;

        if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido))
        {
            Debug.Log("Debes completar los campos.");
            return;
        }

        // Guarda los datos si se necesitan en otra escena
        PlayerPrefs.SetString("Nombre", nombre);
        PlayerPrefs.SetString("Apellido", apellido);

        // Cambia a la siguiente escena (asegúrate de que esté en File > Build Settings)
        SceneManager.LoadScene("pantalla de inicio");
    }
}
