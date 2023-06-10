using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    private Vector3 vectorPoint;
    private Quaternion rotation;
    private Rigidbody rb;

    void Start()
    {
        vectorPoint = transform.position;
        rotation = transform.rotation;
        rb = GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if(other.name == "DEATH")
        {
            transform.position = vectorPoint;
            transform.rotation = rotation;
            rb.velocity = Vector3.zero;
        }
        else if(other.gameObject.tag == "checkpoint")
        {
            //other.gameObject.SetActive(false);
            vectorPoint = transform.position;
            rotation = transform.rotation;
        }
    }
}
