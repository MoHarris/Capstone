using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

    public void QuitGame()
    {
        Debug.Log("Get out of here");
        Application.Quit();
    }
    public void ExitPlayGame()
    {
        ScoreScript.gameInitiated = false;
        SceneManager.LoadScene(1);
    }
}
