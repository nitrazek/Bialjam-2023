using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CameraMovement : MonoBehaviour
{
    public Transform targetTransform;
    public float smoothSpeed = 0.125f;
    private Vector3 offset;
    void Start()
    {
        offset = transform.position - targetTransform.position;
    }

    void FixedUpdate()
    {
        Vector3 desiredPosition = targetTransform.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
        transform.rotation = targetTransform.rotation;
    }
}
