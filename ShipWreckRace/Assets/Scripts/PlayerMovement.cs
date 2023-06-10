using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 30f;
    [SerializeField] private short playerNumber;
    private float distanceToGround;
    private Rigidbody rb;
    private KeyCode[] buttons;

    private void Start()
    {
        Collider collider = GetComponent<Collider>();
        distanceToGround = collider.bounds.extents.y;
        Debug.Log(distanceToGround);
        rb = GetComponent<Rigidbody>();
        buttons = new KeyCode[5];
        if(playerNumber == 1)
        {
            buttons[0] = GameConfig.p1_forward;
            buttons[1] = GameConfig.p1_left;
            buttons[2] = GameConfig.p1_back;
            buttons[3] = GameConfig.p1_right;
        }
        else if(playerNumber == 2)
        {
            buttons[0] = GameConfig.p2_forward;
            buttons[1] = GameConfig.p2_left;
            buttons[2] = GameConfig.p2_back;
            buttons[3] = GameConfig.p2_right;
        }
    }

    private void Update()
    {
        //float horizontalInput = Input.GetAxis("Horizontal");
        //float verticalInput = Input.GetAxis("Vertical");

        //Vector3 movement = verticalInput * moveSpeed * transform.TransformDirection(Vector3.right);
        //rb.AddForce(movement);

        //transform.Rotate(horizontalInput * transform.TransformDirection(Vector3.up));
        transform.eulerAngles.Set(0f, transform.eulerAngles.y, transform.eulerAngles.z);
        Debug.Log(IsGrounded());
        if (IsGrounded()) return;

        if (Input.GetKey(buttons[0]))
        {
            Debug.Log("Do przodu");
            Vector3 movement = moveSpeed * transform.TransformDirection(Vector3.right);
            rb.velocity = movement;
        }

        if (Input.GetKey(buttons[1]))
        {
            Debug.Log("Na lewo");
            transform.Rotate(transform.TransformDirection(Vector3.down));
        }

        if (Input.GetKey(buttons[2]))
        {
            Debug.Log("Do ty³u");
            Vector3 movement = moveSpeed * transform.TransformDirection(Vector3.left);
            rb.AddForce(movement);
        }

        if (Input.GetKey(buttons[3]))
        {
            Debug.Log("Na prawo");
            transform.Rotate(transform.TransformDirection(Vector3.up));
        }
    }

    public bool IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, distanceToGround + 0.1f);
    }
}
