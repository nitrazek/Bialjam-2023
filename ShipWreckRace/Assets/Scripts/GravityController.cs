using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour
{
    private Rigidbody[] allRigidbodies;
    // Start is called before the first frame update
    private void Start()
    {
        allRigidbodies = FindObjectsOfType<Rigidbody>();
    }

    public void DisableGravity()
    {
        foreach(Rigidbody rb in allRigidbodies)
        {
            rb.useGravity = false;
        }
    }

    public void EnableGravity()
    {
        foreach (Rigidbody rb in allRigidbodies)
        {
            rb.useGravity = true;
        }
    }
}
