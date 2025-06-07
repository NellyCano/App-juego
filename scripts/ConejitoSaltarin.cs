using UnityEngine;

/// <summary>
/// Hace que el objeto (como un conejito) se mueva de lado a lado 
/// con un movimiento oscilante, simulando un "baile".
/// </summary>
public class ConejitoBailarin : MonoBehaviour
{
    /// <summary>
    /// Distancia máxima hacia la izquierda y derecha que se moverá el objeto.
    /// </summary>
    public float distancia = 2f;

    /// <summary>
    /// Velocidad del movimiento oscilante.
    /// </summary>
    public float velocidad = 2f;

    /// <summary>
    /// Guarda la posición original del objeto al inicio.
    /// </summary>
    private Vector3 posicionInicial;

    /// <summary>
    /// Registra la posición inicial al comenzar la escena.
    /// </summary>
    void Start()
    {
        posicionInicial = transform.position;
    }

    /// <summary>
    /// Mueve al objeto de manera oscilante en cada frame usando una función seno.
    /// </summary>
    void Update()
    {
        float movimiento = Mathf.Sin(Time.time * velocidad) * distancia;
        transform.position = new Vector3(posicionInicial.x + movimiento, posicionInicial.y, posicionInicial.z);
    }
}
