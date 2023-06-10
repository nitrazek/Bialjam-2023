using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class KeyBindingsUI : MonoBehaviour
{
    [SerializeField] private Button p1_leftInput;
    [SerializeField] private Button p1_rightInput;
    [SerializeField] private Button p1_forwardInput;
    [SerializeField] private Button p1_backInput;
    [SerializeField] private Button p2_leftInput;
    [SerializeField] private Button p2_rightInput;
    [SerializeField] private Button p2_forwardInput;
    [SerializeField] private Button p2_backInput;
    private int lastButtonPressedIndex = 0;
    void Start()
    {
        mapKey(0, p1_leftInput, GameConfig.p1_left.ToString());
        mapKey(0, p1_rightInput, GameConfig.p1_right.ToString());
        mapKey(0, p1_forwardInput, GameConfig.p1_forward.ToString());
        mapKey(0, p1_backInput, GameConfig.p1_back.ToString());

        mapKey(0, p2_leftInput, GameConfig.p2_left.ToString());
        mapKey(0, p2_rightInput, GameConfig.p2_right.ToString());
        mapKey(0, p2_forwardInput, GameConfig.p2_forward.ToString());
        mapKey(0, p2_backInput, GameConfig.p2_back.ToString());

        p1_leftInput.onClick.AddListener(() => mapKey(1, p1_leftInput));
        p1_rightInput.onClick.AddListener(() => mapKey(2, p1_rightInput));
        p1_forwardInput.onClick.AddListener(() => mapKey(3, p1_forwardInput));
        p1_backInput.onClick.AddListener(() => mapKey(4, p1_backInput));

        p2_leftInput.onClick.AddListener(() => mapKey(5, p2_leftInput));
        p2_rightInput.onClick.AddListener(() => mapKey(6, p2_rightInput));
        p2_forwardInput.onClick.AddListener(() => mapKey(7, p2_forwardInput));
        p2_backInput.onClick.AddListener(() => mapKey(8, p2_backInput));
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
        mesh.text = text.ToLower().FirstCharacterToUpper();
    }
}
