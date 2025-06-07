using UnityEngine;

/// <summary>
/// Hace que un objeto (letra) baile moviéndose oscilatoriamente en X e Y.
/// </summary>
public class LetraBailarina : MonoBehaviour
{
    /// <summary>
    /// Amplitud del movimiento oscilante (qué tanto se mueve).
    /// </summary>
    public float amplitud = 0.5f;

    /// <summary>
    /// Velocidad del movimiento oscilante.
    /// </summary>
    public float velocidad = 2f;

    /// <summary>
    /// Posición inicial del objeto para mantener el movimiento relativo.
    /// </summary>
    private Vector3 posicionInicial;

    /// <summary>
    /// Guarda la posición inicial al comenzar.
    /// </summary>
    void Start()
    {
        posicionInicial = transform.position;
    }

    /// <summary>
    /// Actualiza la posición del objeto cada frame para crear un movimiento oscilante tipo "baile".
    /// </summary>
    void Update()
    {
        float y = Mathf.Sin(Time.time * velocidad + transform.position.x) * amplitud;
        float x = Mathf.Cos(Time.time * velocidad + transform.position.y) * amplitud * 0.3f;

        transform.position = posicionInicial + new Vector3(x, y, 0);
    }
}
