using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextSceneUI : MonoBehaviour
{
    [SerializeField] private Button nextButton;
    // Start is called before the first frame update
    private void Awake()
    {
        nextButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("LEVEL1");
        });
    }
}
