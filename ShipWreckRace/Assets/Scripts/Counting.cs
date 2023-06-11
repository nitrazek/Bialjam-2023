using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class Counting : MonoBehaviour
{
    private TextMeshProUGUI counterText;
    private GravityController gravityController;
    private InputController inputController;
    // Start is called before the first frame update
    void Start()
    {
        counterText = GetComponent<TextMeshProUGUI>();
        gravityController = FindObjectOfType<GravityController>();
        inputController = FindObjectOfType<InputController>();
        gravityController.DisableGravity();
        inputController.DisableInput();
        StartCoroutine(CountingCoroutine());
    }

    IEnumerator CountingCoroutine()
    {
        counterText.text = "3";
        yield return new WaitForSeconds(1);
        counterText.text = "2";
        yield return new WaitForSeconds(1);
        counterText.text = "1";
        yield return new WaitForSeconds(1);
        counterText.text = "START!";
        yield return new WaitForSeconds(1);
        gravityController.EnableGravity();
        inputController.EnableInput();
        gameObject.SetActive(false);
    }
}
