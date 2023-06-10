using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 20f;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = verticalInput * moveSpeed * transform.TransformDirection(Vector3.right);
        rb.AddForce(movement);

        transform.Rotate(horizontalInput * transform.TransformDirection(Vector3.up));
    }
}
