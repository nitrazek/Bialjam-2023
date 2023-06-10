using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.Events;

public class PlayerScore : MonoBehaviour
{
    public UnityEvent<PlayerScore> OnPartCollected;
    public int Score { get; private set; }

    public void AddScore()
    {
        Score++;
        OnPartCollected.Invoke(this);
    }
}
