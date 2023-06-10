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
            SceneManager.LoadScene("SampleScene");
        });

        settingsButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("SettingsScene");
        });

        quitButton.onClick.AddListener(() =>
        {
            Application.Quit();
        });
    }
}
