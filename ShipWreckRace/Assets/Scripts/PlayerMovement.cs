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
        // Sprawdzanie naciœniêcia klawiszy 'a' i 'd'
        bool moveLeft = Input.GetKey(KeyCode.A);
        bool moveRight = Input.GetKey(KeyCode.D);

        // Je¿eli naciœniêto oba klawisze jednoczeœnie
        if (moveLeft && moveRight)
        {
            //skakanie
        }
        else
        {
            // Poruszanie siê w lewo
            if (moveLeft)
            {
                ApplyForce(Vector3.left);
            }

            // Poruszanie siê w prawo
            if (moveRight)
            {
                ApplyForce(Vector3.right);
            }
        }
    }
    void ApplyForce(Vector3 direction)
    {
        // Obliczanie si³y na podstawie kierunku i mno¿nika si³y
        Vector3 force = direction * forceMultiplier * Time.deltaTime;
        rb.AddForce(force);
    }
}
