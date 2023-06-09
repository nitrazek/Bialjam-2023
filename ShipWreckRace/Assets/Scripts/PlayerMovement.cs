using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int tiltForce = 20;
    public int pushForce = 5;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        bool keyA = Input.GetKey(KeyCode.A);
        bool keyD = Input.GetKey(KeyCode.D);

        if(keyA && !keyD)
        {
            rb.AddForce(Vector3.left * tiltForce);
            rb.AddForce(Vector3.forward * pushForce);
        }
        else if(!keyA && keyD)
        {
            rb.AddForce(Vector3.right * tiltForce);
            rb.AddForce(Vector3.forward * pushForce);
        }
        else if(keyA && keyD)
        {
            rb.AddForce(Vector3.up * tiltForce * 10);
        }
    }
}
