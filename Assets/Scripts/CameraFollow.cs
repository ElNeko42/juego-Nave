using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform shipTransform; // Referencia a la transformación de la nave
    public float smoothSpeed = 0.125f; // Velocidad con la que la cámara se suaviza al seguir a la nave
    public Vector3 offset; // Offset de la cámara respecto a la nave

    void LateUpdate()
    {
        // Calcula la posición de la cámara usando la posición de la nave y el offset definido
        Vector3 desiredPosition = new Vector3(transform.position.x, shipTransform.position.y + offset.y, transform.position.z);
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Mueve la cámara a la posición suavizada
        transform.position = smoothedPosition;
    }
}
