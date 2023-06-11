using System.Collections;
using System.Collections.Generic;
using AlekGames.HoverCraftSystem.Systems.Main;
using UnityEngine;
using UnityEngine.Events;

public class EndHandler : MonoBehaviour
{
    [SerializeField]
    private InputController inputController;
    [SerializeField] private GameObject endingScreen;
    public int Winner { get; private set; }
    public UnityEvent<EndHandler> OnWinning;

    void Start()
    {
        Winner = 0;
    }

    void OnTriggerStay(Collider other)
    {
        if (Winner == 0 && other.name == "P1_Cube")
        {
            Winner = 1;
        }
        else if(Winner == 0 && other.name == "P2_Cube")
        {
            Winner = 2;
        }
        endingScreen.SetActive(true);
        OnWinning.Invoke(this);
        inputController.DisableInput();
    }
}
