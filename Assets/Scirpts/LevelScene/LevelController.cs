using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    public GameObject levelUI;
    public GameObject GridGroup;

    public Animator transition;

    public Button[] levelButtons;

    void Start()
    {
        levelUI.SetActive(true);
        GridGroup.SetActive(true);
       int levelReached =  PlayerPrefs.GetInt("levelReached", 1);
        for (int i = 0; i < levelButtons.Length; i++)
        {
            if (i + 1 > levelReached)
            {
                levelButtons[i].interactable = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BackToMain()
    {
        StartCoroutine(LoadLevel("Main"));
        
    }
    public void LoadLv1()
    {
        StartCoroutine(LoadLevel("01"));
        Debug.Log("Load LV 01");
    }
    public void LoadLv2()
    {
        
        StartCoroutine(LoadLevel("02"));
        Debug.Log("Load LV 02");
    }
    public void LoadLv3()
    {
        
        //StartCoroutine(LoadLevel("03"));
        Debug.Log("Load LV 03");
    }
    //public void LoadContinue()
    //{
    //    if (PlayerPrefs.GetString("Continue")!="")
    //    {
    //        StartCoroutine(LoadLevel(PlayerPrefs.GetString("Continue")));
    //    }
    //    else
    //    {
    //        LoadLv1();
    //    }
    //}
    IEnumerator LoadLevel(string scene)
    {
        levelUI.SetActive(true);
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(1f);
        GridGroup.SetActive(false);
        SceneManager.LoadScene(scene);
    }
}
