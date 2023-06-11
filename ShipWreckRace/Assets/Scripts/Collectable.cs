using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerScore playerScore = other.GetComponent<PlayerScore>();
        playerScore.AddScore();
        gameObject.SetActive(false);
        setActiveAfterDelay();
    }

    private async void setActiveAfterDelay()
    {
        await Task.Delay(3000);
        gameObject.SetActive(true);
    }
}
