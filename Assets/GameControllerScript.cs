﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControllerScript : MonoBehaviour
{
    public Text mainText;
    public Text scoreText;
    public GameObject foe;
    private int score;
    void Start()
    {
        this.scoreText.text = string.Empty;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartGame()
    {
        this.score = 0;
        this.scoreText.text = this.score.ToString();
        this.mainText.text = string.Empty;
        InvokeRepeating("SummonFoe", 1, 1.5f);
        
    }

    void EndGame()
    {
        this.mainText.text = "Game Over!";
        CancelInvoke("SummonFoe");
    }

    void ScorePlusOne()
    {
        this.score += 1;
        this.scoreText.text = this.score.ToString();
    }

    void SummonFoe()
    {
        float randomWidth = 10 * Random.value - 5;
        GameObject newFoe = Instantiate(foe);
        newFoe.transform.position = new Vector2(15, randomWidth);
    }

    void RestartGame()
    {
        SceneManager.LoadScene("InfinityPhase");
    }
}
