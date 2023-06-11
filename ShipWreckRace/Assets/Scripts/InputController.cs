using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    private bool _isEnabled;
    // Start is called before the first frame update
    void Start()
    {
        EnableInput();
    }

    public void DisableInput()
    {
        _isEnabled = false;
    }

    public void EnableInput()
    {
        _isEnabled = true;
    }

    public bool IsEnabled()
    {
        return _isEnabled;
    }
}
