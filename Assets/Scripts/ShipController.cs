using UnityEngine;

public class ShipController : MonoBehaviour
{
    public float speed = 5.0f; // Velocidad de movimiento hacia arriba
    private float currentRotation = 0f; // Rotaci�n actual de la nave
    private float targetRotation; // Rotaci�n objetivo despu�s del clic

    void Start()
    {
        // Inicializa la rotaci�n objetivo igual a la rotaci�n actual para evitar una rotaci�n inicial
        targetRotation = transform.eulerAngles.z;
    }

    void Update()
    {
        // Mueve la nave hacia arriba constantemente
        transform.Translate(Vector2.up * speed * Time.deltaTime, Space.World);

        // Detecta toques en la pantalla o clics del mouse
        if (Input.GetMouseButtonDown(0) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
        {
            // Alterna la rotaci�n objetivo entre 45 y -45 grados
            if (currentRotation == 0f)
            {
                targetRotation = 45f;
                currentRotation = 45f;
            }
            else if (currentRotation == 45f)
            {
                targetRotation = -45f;
                currentRotation = -45f;
            }
            else if (currentRotation == -45f)
            {
                targetRotation = 45f;
                currentRotation = 45f;
            }

            // Aplica la rotaci�n objetivo a la nave inmediatamente
            transform.rotation = Quaternion.Euler(0f, 0f, targetRotation);
        }
    }
}
