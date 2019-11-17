using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript: MonoBehaviour
{
    public static double scoreValue;
    public static bool gameInitiated = false;

    //scoreVale = PlayerPrefs.GetInt("CurrentScore");
    Text score;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
        DontDestroyOnLoad(gameObject);


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
        if (scoreValue > 0)
        {
            scoreValue = scoreValue - .1;
        }
        else
        {
           SceneManager.LoadScene(7);
            
        }
        score.text = "Score: " + (int)scoreValue;
    }
    void Awake()
    {
        if (FindObjectsOfType(typeof(ScoreScript)).Length > 1)
            DestroyImmediate(gameObject); // Found instance of script in scene... suicide!
    }
    
}
