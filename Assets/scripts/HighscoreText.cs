using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class HighscoreText : MonoBehaviour
{
    Text highscore;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        highscore = GetComponent<Text>();
        highscore.text = "High Score: " + PlayerPrefs.GetInt("HighScore").ToString();
    }
}
