using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float forwardSpeed = 5f; // Pr�dko�� poruszania si� do przodu
    public float rotationSpeed = 3f; // Pr�dko�� skr�cania
    public float maxTiltAngle = 20f; // Maksymalny k�t przechylenia ��dki
    public float tiltSpeed = 2f; // Pr�dko�� przechylania ��dki

    private Rigidbody boatRigidbody;
    private float inputHorizontal;
    private Vector3 previousVelocity;

    private void Awake()
    {
        boatRigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Pobieranie wej�cia od gracza
        inputHorizontal = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        // Pobieranie pr�dko�ci ��dki przed zastosowaniem si�
        previousVelocity = boatRigidbody.velocity;

        // Poruszanie ��dk� do przodu
        boatRigidbody.AddForce(transform.forward * forwardSpeed);

        // Odpychanie si� wios�ami
        if (Mathf.Abs(inputHorizontal) > 0)
        {
            // Dodawanie si�y w bok (zale�nie od kierunku wios�a)
            Vector3 sideForce = transform.right * inputHorizontal * forwardSpeed;
            boatRigidbody.AddForce(sideForce);

            // Skr�canie ��dki
            Quaternion targetRotation = Quaternion.LookRotation(previousVelocity + sideForce, transform.up);
            boatRigidbody.rotation = Quaternion.Lerp(boatRigidbody.rotation, targetRotation, rotationSpeed * Time.fixedDeltaTime);

            // Przechylanie ��dki na boki
            float targetTiltAngle = -inputHorizontal * maxTiltAngle;
            Quaternion targetTilt = Quaternion.Euler(0f, 0f, targetTiltAngle);
            boatRigidbody.rotation = Quaternion.Lerp(boatRigidbody.rotation, targetTilt, tiltSpeed * Time.fixedDeltaTime);
        }
        else
        {
            // Resetowanie przechylenia ��dki
            Quaternion targetTilt = Quaternion.Euler(0f, 0f, 0f);
            boatRigidbody.rotation = Quaternion.Lerp(boatRigidbody.rotation, targetTilt, tiltSpeed * Time.fixedDeltaTime);
        }
    }
}
