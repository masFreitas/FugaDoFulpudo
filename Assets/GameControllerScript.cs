using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControllerScript : MonoBehaviour
{
    public Text mainText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartGame()
    {
        this.mainText.text = string.Empty;
    }

    void EndGame()
    {
        this.mainText.text = "Game Over!";
    }
}
