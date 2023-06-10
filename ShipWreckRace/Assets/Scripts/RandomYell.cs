using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomYell : MonoBehaviour
{
    [SerializeField] private AudioClip[] sounds;
    private AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void PlayRandomYell()
    {
        source.clip = sounds[Random.Range(0, sounds.Length)];
        source.Play();
    }
}
