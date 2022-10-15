using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    
    public float restartDelay = 1f;

    public GameObject completeLevelUI;
    public GameObject countDownUI;

    public int nextLevel = 2;

    float countDownStart;
    public Text countDownText;

    void Start()
    {
        countDownStart = 3.5f;
        PlayerPrefs.SetString("Continue", SceneManager.GetActiveScene().name);
        completeLevelUI.SetActive(false);
        countDownUI.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(countDownStart >= 0)
        {
            CountDown();
            if (FindObjectOfType<PauseMenu>().gameIsPause)
            {
                countDownUI.SetActive(false);
            }
            else
            {

                countDownUI.SetActive(true);
            }
            FindObjectOfType<PlayerCollision>().movement.enabled = false;
        }
        else
        {
            if(!gameHasEnded)
            {
                countDownUI.SetActive(false);
                FindObjectOfType<PlayerCollision>().movement.enabled = true;
            }
        }
    }
   
    public void CountDown()
    {
        countDownStart -= 1 * Time.deltaTime;
        if (countDownStart > 1)
        {
            countDownText.text = countDownStart.ToString("F0");
        }
        else
        {
            countDownText.text = "GO";
        }
        
    }
    public void CompleteLevel()
    {
        Debug.Log("LEVEL " + SceneManager.GetActiveScene().name + " WON");
        
        completeLevelUI.SetActive(true);
        FindObjectOfType<PlayerCollision>().movement.enabled = false;
        PlayerPrefs.SetInt("levelReached", nextLevel);
    }
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
            
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
