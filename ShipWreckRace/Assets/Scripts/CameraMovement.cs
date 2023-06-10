using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform camTarget;
    public float pLerp = .02f;
    public float rLerp = .01f;
    public Vector3 offset;
    public Vector3 rotationOffset;

    void LateUpdate()
    {
        Vector3 targetPosition = camTarget.position - camTarget.forward * offset.z + camTarget.up * offset.y + camTarget.right * offset.x;
        Quaternion targetRotation = camTarget.rotation * Quaternion.Euler(rotationOffset);

        transform.position = Vector3.Lerp(transform.position, targetPosition, pLerp);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, rLerp);
    }
}
