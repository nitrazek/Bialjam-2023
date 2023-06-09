using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float forceMultiplier = 10f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Sprawdzanie naci�ni�cia klawiszy 'a' i 'd'
        bool moveLeft = Input.GetKey(KeyCode.A);
        bool moveRight = Input.GetKey(KeyCode.D);

        // Je�eli naci�ni�to oba klawisze jednocze�nie
        if (moveLeft && moveRight)
        {
            //skakanie
        }
        else
        {
            // Poruszanie si� w lewo
            if (moveLeft)
            {
                ApplyForce(Vector3.left);
            }

            // Poruszanie si� w prawo
            if (moveRight)
            {
                ApplyForce(Vector3.right);
            }
        }
    }
    void ApplyForce(Vector3 direction)
    {
        // Obliczanie si�y na podstawie kierunku i mno�nika si�y
        Vector3 force = direction * forceMultiplier * Time.deltaTime;
        rb.AddForce(force);
    }
}
