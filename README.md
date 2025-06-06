# Juego Educativo: Evaluación de Oraciones - Proyecto Unity

## Descripción
Este proyecto es un juego educativo desarrollado en Unity para apoyar el aprendizaje de estudiantes de tercer grado en la competencia de lengua y literatura, específicamente en el tema de ** Orciones según su modalidad**. El juego incluye actividades interactivas con retroalimentación inmediata visual y sonora, puntajes y avance a través de diferentes niveles.

---

## Requisitos
- Unity 2023.1 o superior
- Sistema operativo Windows o Android
- Audio habilitado para sonidos
- Paquete TextMeshPro importado (para uso de TMP_InputField)

---

## Estructura del repositorio

- `/Assets`: Recursos del juego como imágenes, sonidos, escenas.
- `/Scripts`: Código fuente C# con la lógica del juego, que incluye:
  - `Progreso1.cs` — Controla la barra de progreso y carga escenas.
  - `RetroalimentacionManager1.cs` — Maneja botones, retroalimentación y puntajes para la actividad 1 (opción verdadero/falso).
  - `RetroalimentacionManager2.cs` — Igual que el anterior, pero para la actividad 2.
  - `VerificadorRespuesta.cs` — Valida respuestas de texto para actividades escritas con retroalimentación.
  - ... (otros scripts relacionados)
- `/DocumentationSite`: Carpeta con el sitio web de documentación del código (HTML, CSS, JS).
- `README.md`: Este archivo con la documentación general del proyecto.

---

## Descripción de los scripts principales

### Progreso1.cs
- Controla una barra de progreso que avanza automáticamente.
- Al completar el progreso, cambia a la escena especificada (por ejemplo, un nivel).

### RetroalimentacionManager1.cs y RetroalimentacionManager2.cs
- Controlan la retroalimentación para preguntas de opción múltiple tipo "Verdadero" o "Falso".
- Activan paneles de retroalimentación visual para respuestas correctas o incorrectas.
- Reproducen sonidos asociados a la respuesta.
- Guardan el puntaje obtenido usando `PlayerPrefs`.
- Permiten avanzar a la siguiente escena con botones dentro de cada panel.

### VerificadorRespuesta.cs
- Permite que el usuario ingrese una respuesta escrita.
- Verifica la respuesta contra la respuesta correcta (ejemplo: "interrogativa").
- Muestra paneles de retroalimentación para respuestas correctas o incorrectas.
- Guarda puntaje y reproduce sonidos según la respuesta.
- Botones para avanzar a la siguiente escena.

---

## Cómo usar el proyecto

1. Abre el proyecto en Unity.
2. Asegúrate de que las escenas y scripts estén asignados correctamente.
3. Ejecuta la escena principal o la de nivel deseada.
4. Interactúa con las actividades (responder verdadero/falso,opción múltiple,opción única.acerti).
5. Observa la retroalimentación y el avance a escenas siguientes.

---

## Gestión de puntajes

- Se usa `PlayerPrefs` para guardar el puntaje de cada actividad bajo claves como `"PuntosActividad1"` o `"PuntosActividad2"`.
- Los puntajes se establecen como 100 para respuestas correctas y 0 para incorrectas.

---

## Audio

- Los scripts reproducen efectos de sonido para respuestas correctas e incorrectas usando `AudioSource` y `AudioClip`.
- Los clips se asignan en el Inspector y también hay sonidos para cada nivel.

---

## Contacto y créditos

Desarrollado por: **Las Anónimas**  
   Integrantes: Arlen Díaz
               Keysi Orozco
               Nelly cano
Contacto: [nellycano@gmail.com](mailto:nellycano@gmail.com)  

---

## Historial de versiones y etiquetas

Este proyecto utiliza Git para control de versiones con etiquetas importantes como:

- `v1.0-inicial` — Versión base con funcionalidades de retroalimentación.
- `v1.1-sonidos` — Se agregaron sonidos para respuestas.
- `v1.2-avance` — Implementación de barra de progreso y cambio de escenas.

---
Este proyecto nace del deseo de aprender, crear y compartir. Cada línea de código aquí representa no solo funcionalidad, sino también dedicación. Si estás leyendo esto, ¡gracias por formar parte del viaje!



