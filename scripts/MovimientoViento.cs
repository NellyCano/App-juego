using UnityEngine;

/// <summary>
/// Simula el movimiento de balanceo por el viento.
/// </summary>
public class MovimientoViento : MonoBehaviour
{
    /// <summary>
    /// Velocidad del movimiento de balanceo.
    /// </summary>
    public float velocidad = 1f;

    /// <summary>
    /// Amplitud del ángulo de inclinación (en grados).
    /// </summary>
    public float amplitud = 5f;

    /// <summary>
    /// Guarda la rotación inicial del objeto para aplicar el balanceo relativo.
    /// </summary>
    private Quaternion rotacionInicial;

    /// <summary>
    /// Guarda la rotación inicial al iniciar el juego.
    /// </summary>
    void Start()
    {
        rotacionInicial = transform.rotation;
    }

    /// <summary>
    /// Actualiza la rotación del objeto para simular el balanceo.
    /// </summary>
    void Update()
    {
        // Calcula el ángulo de inclinación usando una función seno para movimiento suave.
        float angulo = Mathf.Sin(Time.time * velocidad) * amplitud;

        // Aplica la rotación sobre el eje Z, sumándola a la rotación inicial.
        transform.rotation = rotacionInicial * Quaternion.Euler(0f, 0f, angulo);
    }
}
