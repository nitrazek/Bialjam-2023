using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerScore : MonoBehaviour
{
    public int score { get; private set; }

    public void AddScore()
    {
        score++;
    }
}
