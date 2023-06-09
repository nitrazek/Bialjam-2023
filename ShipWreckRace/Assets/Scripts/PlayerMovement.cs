using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.W))
        {

        }

        if(Input.GetKey(KeyCode.S))
        {

        }

        if(Input.GetKey(KeyCode.A))
        {
            
        }

        if(Input.GetKey(KeyCode.D))
        {

        }
    }
}
