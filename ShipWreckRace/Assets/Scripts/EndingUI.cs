using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndingUI : MonoBehaviour
{
    [SerializeField] private Button nextLevelButton;
    [SerializeField] private string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        nextLevelButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(sceneName);
        });
    }
}
