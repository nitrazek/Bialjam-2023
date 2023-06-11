using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndHandler : MonoBehaviour
{
    [SerializeField]
    private Camera p1_camera;
    [SerializeField]
    private Camera p2_camera;
    private int winner;

    void Start()
    {
        winner = 0;
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.name == "player1")
        {
            
        }
        else if(other.gameObject.name == "player2")
        {

        }
    }
}
