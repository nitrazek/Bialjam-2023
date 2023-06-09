using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField] private Button playButton;
    [SerializeField] private Button settingsButton;
    [SerializeField] private Button quitButton;

    // Start is called before the first frame update
    private void Awake()
    {
        playButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(1);
        });

        settingsButton.onClick.AddListener(() =>
        {
            // przechodzi na scen� z ustawieniami
        });

        quitButton.onClick.AddListener(() =>
        {
            Application.Quit();
        });
    }
}
