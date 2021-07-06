using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagement : MonoBehaviour
{
    public Text scoreText;

    private int score;

    void Start()
    {
        Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Initialize()
    {
        score = 0;
    }

    public void AddScore()
    {
        score += 100;
        scoreText.text = "Score:" + score.ToString(); 
    }
}
