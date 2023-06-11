using AlekGames.HoverCraftSystem.Systems.Main;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.VisualScripting.Member;

public class CheckPoint : MonoBehaviour
{
    private AudioSource source;
    private Vector3 vectorPoint;
    private Quaternion rotation;
    private Rigidbody rb;
    private int playerId;

    void Start()
    {
        vectorPoint = transform.position;
        rotation = transform.rotation;
        rb = GetComponent<Rigidbody>();
        playerId = GetComponent<hoverCraft>().getPlayerId();
        source = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (playerId == 1 && Input.GetKeyDown(GameConfig.p1_reset))
        {
            transform.position = vectorPoint;
            transform.rotation = rotation;
            rb.velocity = Vector3.zero;
            source.Play();
        }
        else if (playerId == 2 && Input.GetKeyDown(GameConfig.p2_reset))
        {
            transform.position = vectorPoint;
            transform.rotation = rotation;
            rb.velocity = Vector3.zero;
            source.Play();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.name == "DEATH")
        {
            transform.position = vectorPoint;
            transform.rotation = rotation;
            rb.velocity = Vector3.zero;
            source.Play();
        }
        else if(other.gameObject.tag == "checkpoint")
        {
            //other.gameObject.SetActive(false);
            vectorPoint = other.transform.position;
            rotation = transform.rotation;
        }
    }
}
