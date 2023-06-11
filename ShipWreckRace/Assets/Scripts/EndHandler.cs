using System.Collections;
using System.Collections.Generic;
using AlekGames.HoverCraftSystem.Systems.Main;
using UnityEngine;

public class EndHandler : MonoBehaviour
{
    private int winner;

    void Start()
    {
        winner = 0;
    }

    void OnTriggerEnter(Collider other)
    {
        if (winner == 0 && other.name == "P1_Cube")
        {
            winner = 1;
        }
        else if(winner == 0 && other.name == "P2_Cube")
        {
            winner = 2;
        }
        Debug.Log(winner);
    }
}
