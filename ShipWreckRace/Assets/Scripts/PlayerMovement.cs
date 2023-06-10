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
        //if (Input.GetKey(GameConfig.p1_forward))
        //{
        //    Debug.Log(Input.GetKey(GameConfig.p1_forward));
        //    Vector3 movement = moveSpeed * transform.TransformDirection(Vector3.right);
        //    rb.AddForce(movement, ForceMode.Impulse);
        //} 

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Debug.Log("Horizontal: " + horizontalInput);
        Debug.Log("Vertical: " + verticalInput);

        Vector3 movement = verticalInput * moveSpeed * transform.TransformDirection(Vector3.right);
        rb.AddForce(movement, ForceMode.Impulse);

        transform.Rotate(horizontalInput * transform.TransformDirection(Vector3.up));
    }
}
