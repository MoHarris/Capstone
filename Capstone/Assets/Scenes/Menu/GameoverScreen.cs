using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public static bool GameIsPaused = true;

    public GameObject GameOverUI;

    [SerializeField] private string loadLevel;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (GameIsPaused)
            {
                Pause();
            }
        }
    }

    void Pause()
    {
        GameOverUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
        ScoreScript.gameInitiated = false;
    }

    public void QuitGame()
    {
        Debug.Log("Get out Of here");
        Application.Quit();
    }
}