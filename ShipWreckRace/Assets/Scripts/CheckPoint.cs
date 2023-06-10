using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    private Vector3 vectorPoint;
    private Quaternion rotation;

    void Start()
    {
        vectorPoint = transform.position;
        rotation = transform.rotation;
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if(other.name == "DEATH")
        {
            transform.position = vectorPoint;
            transform.rotation = rotation;
        }
        else if(other.gameObject.tag == "checkpoint")
        {
            other.gameObject.SetActive(false);
            vectorPoint = transform.position;
            rotation = transform.rotation;
        }
    }
}
