using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectPart : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if (playerInventory == null) return;
        playerInventory.AddPart();
        gameObject.SetActive(false);
    }
}
