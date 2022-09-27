using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    //public Transform player;

    public Text scoreText;
    public Text highScore;

    public float highscoreValue;
    public float scoreAmount;

    public float pointByCoin = 10;

    void Start()
    {
        scoreAmount = 0f;
    }

    
    void Update()
    {
        string levelCheck = SceneManager.GetActiveScene().name.ToString();
        //scoreAmount = player.position.z;
        scoreText.text = scoreAmount.ToString("F0");
        highscoreValue = PlayerPrefs.GetFloat(levelCheck,0);
        highScore.text = "High Score: " + highscoreValue.ToString("F0");
        if (scoreAmount > highscoreValue)
        {
            PlayerPrefs.SetFloat(levelCheck, scoreAmount);
            Debug.Log(highscoreValue);
        }
    }
    public void GetCoin()
    {
        scoreAmount += pointByCoin;
    }
}
