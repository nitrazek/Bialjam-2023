using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform leftOar;
    public Transform rightOar;
    private float speed = 300f;
    void Start()
    {

    }

    void Update()
    {
        bool keyA = Input.GetKey(KeyCode.A);
        bool keyD = Input.GetKey(KeyCode.D);

        if(keyA)
        {
            leftOar.Rotate(Vector3.back * speed * Time.deltaTime);
            leftOar.Rotate(Vector3.up * speed * Time.deltaTime);
        }

        if(keyD)
        {
            rightOar.Rotate(Vector3.forward * speed * Time.deltaTime);
            rightOar.Rotate(Vector3.down * speed * Time.deltaTime);
        }
    }
}
