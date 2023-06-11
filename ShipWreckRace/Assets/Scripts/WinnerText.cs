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
    }

    public void UpdateWinnerText(EndHandler endHandler)
    {
        if (endHandler == null) return;
        winnerText.text = "Player " + endHandler.Winner.ToString();
    }
}
