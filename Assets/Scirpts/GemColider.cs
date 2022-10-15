using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemColider : MonoBehaviour
{
    public GameObject audioGetCoin;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 90 * Time.deltaTime,0);
    }
    //void OnCollisionEnter(Collision collisionCoin)
    //{
    //    if(collisionCoin.collider.tag == "Player")
    //    {
    //        Destroy(gameObject,0.1f);
    //    }
    //}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Instantiate(audioGetCoin, transform.position, Quaternion.identity);
            FindObjectOfType<Score>().GetGem();
            Destroy(gameObject);
        }
    }
}
