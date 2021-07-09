using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagement : MonoBehaviour
{
    public Text scoreText;
    private int score;
    public int currentScore;

    public Text timerText;

    public float gameTime = 60f;
    int seconds;

    public GameObject gamePauseUI;


    void Start()
    {
        Initialize();
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        TimeManagement();
    }

    private void Initialize()
    {
        score = 0;
    }

    public void TimeManagement()
    {
        gameTime -= Time.deltaTime;
        seconds = (int)gameTime;
        timerText.text = seconds.ToString();

        if (seconds == 0)
        {
            GameOver();
        }
    }
    public void AddScore()
    {
        score += 100;
        scoreText.text = "Score:" + score.ToString(); 
    }

    public void GameOver()
    {
        //SceneManager.LoadScene(SceneManager.GetActive().name);
    }

    public void GamePause()
    {
        GamePauseToggle();
    }

    public void GamePauseToggle()
    {
        gamePauseUI.SetActive(!gamePauseUI.activeSelf);

        if (gamePauseUI.activeSelf)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }
}
