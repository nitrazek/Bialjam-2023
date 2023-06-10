using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class KeyBindingsUI : MonoBehaviour
{
    [SerializeField] private Button p1_leftInput;
    [SerializeField] private Button p1_rightInput;
    [SerializeField] private Button p2_leftInput;
    [SerializeField] private Button p2_rightInput;
    private int lastButtonPressedIndex = 0;
    void Start()
    {
        p1_leftInput.onClick.AddListener(() => mapKey(1, p1_leftInput));
        p1_rightInput.onClick.AddListener(() => mapKey(2, p1_rightInput));
        p2_leftInput.onClick.AddListener(() => mapKey(3, p2_leftInput));
        p2_rightInput.onClick.AddListener(() => mapKey(4, p2_rightInput));
    }

    void Update()
    {
        if (lastButtonPressedIndex == 0) return;
        if (!Input.anyKeyDown) return;

        KeyCode pressedKey = KeyCode.None;
        foreach (KeyCode keyCode in System.Enum.GetValues(typeof(KeyCode)))
        {
            if (Input.GetKeyDown(keyCode))
            {
                pressedKey = keyCode;
                break;
            }
        }
        if(pressedKey == KeyCode.None)
            return;

        switch (lastButtonPressedIndex)
        {
            case 1:
                GameConfig.p1_left = pressedKey;
                mapKey(0, p1_leftInput, pressedKey.ToString());
                break;
            case 2:
                GameConfig.p1_right = pressedKey;
                mapKey(0, p1_rightInput, pressedKey.ToString());
                break;
            case 3:
                GameConfig.p2_left = pressedKey;
                mapKey(0, p2_leftInput, pressedKey.ToString());
                break;
            case 4:
                GameConfig.p2_right = pressedKey;
                mapKey(0, p2_rightInput, pressedKey.ToString());
                break;
        }
        lastButtonPressedIndex = 0;
    }

    private void mapKey(int buttonIndex, Button buttonObj, string text = "< >")
    {
        lastButtonPressedIndex = buttonIndex;
        TextMeshProUGUI mesh = buttonObj.GetComponentInChildren<TextMeshProUGUI>();
        if (!mesh) return;
        Debug.Log(text);
        mesh.text = text.ToUpperInvariant();
    }
}
