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
    public UnityEvent<EndHandler> OnWinning;
    public int Winner { get; private set; }

    void Start()
    {
        Winner = 0;
        OnWinning = new UnityEvent<EndHandler>();
    }

    void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<PlayerScore>().Score < 5) return;

        if (Winner == 0 && other.name == "P1_Cube")
        {
            Winner = 1;
        }
        else if(Winner == 0 && other.name == "P2_Cube")
        {
            Winner = 2;
        }
        endingScreen.SetActive(true);
        if (OnWinning == null) Debug.Log("lololol");
        if(OnWinning != null) OnWinning.Invoke(this);
        inputController.DisableInput();
    }
}
