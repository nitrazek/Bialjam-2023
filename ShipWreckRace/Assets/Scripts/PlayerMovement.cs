using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed = 50f;
    private float maxAngle;
    private float minAngle;
    private int rotateCounter;

    void Start()
    {
        float y = transform.rotation.y;
        minAngle = y + 45f;
        maxAngle = y - 45f;
        rotateCounter = 0;
    }

    void Update()
    {
        float axis = Input.GetAxis("Horizontal");
        if (axis != 0)
        {
            float rotation = axis * speed * Time.deltaTime;
            Debug.Log("Rotacja: " + rotation);
            rotateCounter = rotateCounter + 1;
            Debug.Log("Counter: " + rotateCounter);
            transform.Rotate(0f, 0f, rotation);

            /*Quaternion currentRotation = transform.rotation;
            Vector3 currentEulerAngles = currentRotation.eulerAngles;
            float clampedAngle = Mathf.Clamp(currentEulerAngles.z, minAngle, maxAngle);
            currentEulerAngles.z = clampedAngle;
            transform.rotation = Quaternion.Euler(currentEulerAngles);*/
        }
    }

    void OnCollisionStay(Collision collision)
    {
        Debug.Log("Dupa");
    }
}
