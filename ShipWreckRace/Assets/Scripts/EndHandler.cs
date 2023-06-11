using System.Collections;
using System.Collections.Generic;
using AlekGames.HoverCraftSystem.Systems.Main;
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

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "P1_Cube")
        {
            if (winner == 0) winner = 1;
            p1_camera.GetComponent<camera>().updatePosition = false;

        }
        else if (other.name == "P2_Cube")
        {
            if (winner == 0) winner = 2;
            p2_camera.GetComponent<camera>().updatePosition = false;
        }
    }
}
