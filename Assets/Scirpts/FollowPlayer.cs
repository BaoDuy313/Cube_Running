using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    void Start()
    {
        Debug.Log("Follow_Player Scripts");
    }

    
    void Update()
    {
        transform.position = player.position + offset;
    }
}
