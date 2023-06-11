using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField] private Button playButton;
    [SerializeField] private Button settingsButton;
    [SerializeField] private Button quitButton;
    [SerializeField] private Button yellButton;
    [SerializeField] private UnityEvent<MainMenuUI> OnYellButtonClicked;

    // Start is called before the first frame update
    private void Awake()
    {
        playButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("after-play-scene");
        });

        settingsButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("SettingsScene");
        });

        yellButton.onClick.AddListener(() =>
        {
            OnYellButtonClicked.Invoke(this);
        });

        quitButton.onClick.AddListener(() =>
        {
            Application.Quit();
        });
    }
}
