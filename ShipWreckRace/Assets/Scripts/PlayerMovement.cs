using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float forwardSpeed = 5f; // Prêdkoœæ poruszania siê do przodu
    public float rotationSpeed = 3f; // Prêdkoœæ skrêcania
    public float maxTiltAngle = 20f; // Maksymalny k¹t przechylenia ³ódki
    public float tiltSpeed = 2f; // Prêdkoœæ przechylania ³ódki

    private Rigidbody boatRigidbody;
    private float inputHorizontal;
    private Vector3 previousVelocity;

    private void Awake()
    {
        boatRigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Pobieranie wejœcia od gracza
        inputHorizontal = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        // Pobieranie prêdkoœci ³ódki przed zastosowaniem si³
        previousVelocity = boatRigidbody.velocity;

        // Poruszanie ³ódk¹ do przodu
        boatRigidbody.AddForce(transform.forward * forwardSpeed);

        // Odpychanie siê wios³ami
        if (Mathf.Abs(inputHorizontal) > 0)
        {
            // Dodawanie si³y w bok (zale¿nie od kierunku wios³a)
            Vector3 sideForce = transform.right * inputHorizontal * forwardSpeed;
            boatRigidbody.AddForce(sideForce);

            // Skrêcanie ³ódki
            Quaternion targetRotation = Quaternion.LookRotation(previousVelocity + sideForce, transform.up);
            boatRigidbody.rotation = Quaternion.Lerp(boatRigidbody.rotation, targetRotation, rotationSpeed * Time.fixedDeltaTime);

            // Przechylanie ³ódki na boki
            float targetTiltAngle = -inputHorizontal * maxTiltAngle;
            Quaternion targetTilt = Quaternion.Euler(0f, 0f, targetTiltAngle);
            boatRigidbody.rotation = Quaternion.Lerp(boatRigidbody.rotation, targetTilt, tiltSpeed * Time.fixedDeltaTime);
        }
        else
        {
            // Resetowanie przechylenia ³ódki
            Quaternion targetTilt = Quaternion.Euler(0f, 0f, 0f);
            boatRigidbody.rotation = Quaternion.Lerp(boatRigidbody.rotation, targetTilt, tiltSpeed * Time.fixedDeltaTime);
        }
    }
}
