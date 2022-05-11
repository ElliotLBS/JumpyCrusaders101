using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //anv�nds inte, men skriven av Theo
    public Transform target;
    public Vector3 offset;// kan v�lja kamera offset fr�n 1 - 10 
    [Range(1, 10)]
    public float smoothFactor;

    private void FixedUpdate()
    {
        Follow();
    }

    void Follow()

    {
        Vector3 targetPosision = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, targetPosision, smoothFactor * Time.fixedDeltaTime);
        transform.position = targetPosision;
    }
}

