using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager sManager;
    public Text scoreText;
    public int playerScore = 0;

    void Start()
    {
        sManager = this;
    }
    void Update()
    {
        scoreText.text = playerScore.ToString();
    }

    public void IncreaseScore(int Increase)
    {
        playerScore += Increase;
    }
}
