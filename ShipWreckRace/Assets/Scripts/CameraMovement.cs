using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform camTarget;
    public float pLerp = .02f;
    public Vector3 offset;

    private void LateUpdate()
    {
        Vector3 targetPosition = camTarget.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetPosition, pLerp);

        transform.LookAt(camTarget);
    }
}
