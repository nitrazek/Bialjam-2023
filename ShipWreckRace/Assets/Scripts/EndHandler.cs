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

    private void OnTriggerEnter(Collider other)
    {
        if(winner == 0 && other.gameObject.name == "player1")
        {
            winner = 1;
        }
        else if(winner == 0 && other.gameObject.name == "player2")
        {
            winner = 2;
        }

        camera cm = other.GetComponent<camera>();
        cm.DisableUpdate();
    }
}
