using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPause = false;

    public GameObject pauseMenuUI;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPause)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPause = false;
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPause = true;
    }

    public void LoadMenu()
    {
        StartCoroutine(LoadLevel("Main"));
        Time.timeScale = 1f;
        Debug.Log("Loading Menu.......");
    }
    public void QuitGame()
    {
        Debug.Log("Quitting.......");
    }
    IEnumerator LoadLevel(string scene)
    {
        
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(scene);
    }
}
