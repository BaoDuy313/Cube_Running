using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainController : MonoBehaviour
{
    public Animator cubeTransition;
    public Animator textTransition;


    void Start()
    {
       
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void LevelScene()
    {

        cubeTransition.SetTrigger("play");
       
        textTransition.SetTrigger("play");
        Invoke("Level", 1f);

    }
    void Level()
    {
        SceneManager.LoadScene("Level");
    }
    public void QuitGame()
    {
        Debug.Log("Quitting.......");
    }
}
