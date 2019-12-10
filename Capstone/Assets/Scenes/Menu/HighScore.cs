using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public static double scoreValue;
    public static bool gameInitiated = false;
    //scoreVale = PlayerPrefs.GetInt("CurrentScore");
    Text score;
    Text Highscore;

    // Start is called before the first frame update
    /*void Start()
    {
        public static double currentvalue;
        ScoreScript.scoreValue = currentvalue;
        score = GetComponent<Text>();
        DontDestroyOnLoad(gameObject);

        Highscore.text = PlayerPrefs.GetString("HighScore", "0");


        if (gameInitiated)
        {
            scoreValue += 100;
        }
        else
        {
            scoreValue = 1000;
            gameInitiated = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        score.text =  (int)scoreValue;
    }
    void Awake()
    {
        if (FindObjectsOfType(typeof(ScoreScript)).Length > 1)
            DestroyImmediate(gameObject); // Found instance of script in scene... suicide!
    }
    public void highscore()
    {
        if (scoreValue > PlayerPrefs.GetInt("HighScore", 0))
        {
            string scoreValuer = scoreValue.ToString();
            PlayerPrefs.SetString("Highscore", scoreValuer);
            highscore.text = scoreValuer;
        }



    }*/

}
