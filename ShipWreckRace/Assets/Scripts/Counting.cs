using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class Counting : MonoBehaviour
{
    private TextMeshProUGUI counterText;
    [SerializeField] private GravityController gravityController;
    [SerializeField] private InputController inputController;
    // Start is called before the first frame update
    //private void OnEnable()
    //{
    //    SceneManager.activeSceneChanged += OnActiveSceneChanged;
    //}

    //private void OnDisable()
    //{
    //    SceneManager.activeSceneChanged -= OnActiveSceneChanged;
    //}

    //private void OnActiveSceneChanged(Scene previousScene, Scene currentScene)
    //{
    //    Debug.Log("dupalalaparampam");
    //    //if (currentScene.name != sceneName) return;
    //    counterText = GetComponent<TextMeshProUGUI>();
    //    gravityController = FindObjectOfType<GravityController>();
    //    inputController = FindObjectOfType<InputController>();
    //    gravityController.DisableGravity();
    //    inputController.DisableInput();
    //    Debug.Log(inputController.IsEnabled());
    //    StartCoroutine(CountingCoroutine());
    //}

    private void Start()
    {
        //if (currentScene.name != sceneName) return;
        counterText = GetComponent<TextMeshProUGUI>();
        gravityController.DisableGravity();
        inputController.DisableInput();
        Debug.Log(inputController.IsEnabled());
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
