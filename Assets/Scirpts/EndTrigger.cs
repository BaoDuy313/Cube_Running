using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public AudioSource audioSource;
    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
        audioSource.Play();
    }
}
