using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScore : MonoBehaviour {
    public static int scoreValue = 1000;
    Text score;

    // Start is called before the first frame update
    void Start()
    {
    score = GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreValue > 0)
        {
            scoreValue = scoreValue - 20 ;
        }
        else
        {
            Application.Quit();
        }
    score.text = "Score: " + scoreValue;
    }
}

