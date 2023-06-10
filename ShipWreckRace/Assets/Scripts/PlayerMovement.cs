using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 4000f;
    [SerializeField] private float rotationSpeed = 150f;
    [SerializeField] private short playerNumber;
    private BoxCollider boxCollider;
    private Rigidbody rb;
    private KeyCode[] buttons;

    private int collectibles;

    private void Start()
    {
        collectibles = 0;
        rb = GetComponent<Rigidbody>();
        boxCollider = rb.GetComponent<BoxCollider>();
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
        //Debug.Log(IsGrounded());
        if (!IsGrounded()) return;

        if (Input.GetKey(buttons[0]))
        {
            //Debug.Log("Do przodu");
            rb.velocity = moveSpeed * Time.deltaTime * transform.TransformDirection(Vector3.right);
        }

        if (Input.GetKey(buttons[1]))
        {
            //Debug.Log("Na lewo");
            transform.Rotate(rotationSpeed * Time.deltaTime * Vector3.down);
        }

        if (Input.GetKey(buttons[2]))
        {
            //Debug.Log("Do ty�u");
            rb.AddForce(moveSpeed * Time.deltaTime * transform.TransformDirection(Vector3.left));
        }

        if (Input.GetKey(buttons[3]))
        {
            //Debug.Log("Na prawo");
            transform.Rotate(rotationSpeed * Time.deltaTime * Vector3.up);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "collectible")
        {
            other.gameObject.SetActive(false);
            collectibles++;
            Debug.Log(collectibles);
        }
    }
    
    private bool IsGrounded()
    {
        return Physics.Raycast(boxCollider.bounds.center, Vector3.down, boxCollider.bounds.extents.y + 1f);
    }
}
