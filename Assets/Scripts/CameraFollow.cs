using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform shipTransform; // Referencia a la transformaci�n de la nave
    public float smoothSpeed = 0.125f; // Velocidad con la que la c�mara se suaviza al seguir a la nave
    public Vector3 offset; // Offset de la c�mara respecto a la nave

    void LateUpdate()
    {
        // Calcula la posici�n de la c�mara usando la posici�n de la nave y el offset definido
        Vector3 desiredPosition = new Vector3(transform.position.x, shipTransform.position.y + offset.y, transform.position.z);
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Mueve la c�mara a la posici�n suavizada
        transform.position = smoothedPosition;
    }
}
