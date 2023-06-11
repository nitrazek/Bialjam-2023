using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinnerText : MonoBehaviour
{
    private TextMeshProUGUI winnerText;
    // Start is called before the first frame update
    void Start()
    {
        winnerText = GetComponent<TextMeshProUGUI>();
        EndHandler endHandler = FindObjectOfType<EndHandler>();
        if (endHandler != null)
        {
            endHandler.OnWinning.AddListener(UpdateWinnerText);
        }
    }

    public void UpdateWinnerText(EndHandler endHandler)
    {
        winnerText.text = "Player " + endHandler.Winner.ToString();
    }
}
