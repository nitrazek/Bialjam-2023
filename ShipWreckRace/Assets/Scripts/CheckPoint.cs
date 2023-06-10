using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    [SerializeField]
    List<GameObject> checkPoints;
    [SerializeField]
    Vector3 vectorPoint;

    void Start()
    {
        vectorPoint = transform.position;
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if(other.name == "DEATH")
        {
            transform.position = vectorPoint;
        }
        else if(other.gameObject.tag == "checkpoint")
        {
            other.gameObject.SetActive(false);
            vectorPoint = transform.position;
        }
    }
}
