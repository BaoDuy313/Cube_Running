using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public AudioSource audioSource;
    //public AudioClip hitAudio;


    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        //movement.GetComponent<PlayerMovement>();
    }
    void Start()
    {
        Debug.Log("Player_Collision Scripts");
    }

    
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            audioSource.Play();
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
       
    }
}
