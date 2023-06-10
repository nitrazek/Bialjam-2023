using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerScore playerScore = other.GetComponent<PlayerScore>();
        playerScore.AddScore();
        gameObject.SetActive(false);
    }
}
