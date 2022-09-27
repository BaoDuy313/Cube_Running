using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCubeRotation : MonoBehaviour
{

    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(90 * Time.deltaTime, 90 * Time.deltaTime, 90 * Time.deltaTime);
    }
    
}
