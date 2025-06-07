using UnityEngine;

/// <summary>
/// Realiza un zoom suave y lento en un objeto, alternando entre un tamaño mínimo y máximo.
/// </summary>
public class LibroZoomLento : MonoBehaviour
{
    /// <summary>
    /// Tamaño máximo al que llegará el zoom.
    /// </summary>
    public float escalaMax = 1.05f;

    /// <summary>
    /// Tamaño mínimo al que llegará el zoom.
    /// </summary>
    public float escalaMin = 0.95f;

    /// <summary>
    /// Velocidad del efecto de zoom.
    /// </summary>
    public float velocidad = 1f;

    /// <summary>
    /// Guarda la escala inicial del objeto para hacer el zoom relativo a esta.
    /// </summary>
    private Vector3 escalaInicial;

    /// <summary>
    /// Guarda la escala inicial al iniciar el script.
    /// </summary>
    void Start()
    {
        escalaInicial = transform.localScale;
    }

    /// <summary>
    /// Actualiza la escala del objeto suavemente para crear un efecto de zoom tipo "respiración".
    /// </summary>
    void Update()
    {
        float escala = Mathf.Lerp(escalaMin, escalaMax, (Mathf.Sin(Time.time * velocidad) + 1f) / 2f);
        transform.localScale = escalaInicial * escala;
    }
}
