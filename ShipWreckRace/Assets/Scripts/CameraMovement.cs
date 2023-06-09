using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CameraMovement : MonoBehaviour
{
    public Transform targetTransform;
    private Vector3 offset;
    void Start()
    {
        offset = transform.position - targetTransform.position;
    }

    void FixedUpdate()
    {
        
    }
}
