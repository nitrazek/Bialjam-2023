using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AfterPlaySceneUI : MonoBehaviour
{
    [SerializeField] private Button nextButton;
    [SerializeField] private Button skipButton;
    // Start is called before the first frame update
    private void Awake()
    {
        nextButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("next");
        });

        skipButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("LEVEL1");
        });
    }
}
