using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 30f;
    [SerializeField] private float rotationSpeed = 50f;
    [SerializeField] private short playerNumber;
    private Rigidbody rb;
    private KeyCode[] buttons;

    private void Start()
    {
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

        if (Input.GetKey(buttons[0]))
        {
            Debug.Log("Do przodu");
            Vector3 movement = moveSpeed * transform.TransformDirection(Vector3.right);
            rb.velocity = movement;
        }

        if (Input.GetKey(buttons[1]))
        {
            Debug.Log("Na lewo");
            transform.Rotate(rotationSpeed * Time.deltaTime * Vector3.down);
        }

        if (Input.GetKey(buttons[2]))
        {
            Debug.Log("Do ty³u");
            rb.velocity = moveSpeed * transform.TransformDirection(Vector3.left);
        }

        if (Input.GetKey(buttons[3]))
        {
            Debug.Log("Na prawo");
            transform.Rotate(rotationSpeed * Time.deltaTime * Vector3.up);
        }
    }

    private void Balance()
    {

    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("kolidjuesz!!");
    }
}
