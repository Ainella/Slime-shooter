using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    //Loads the first level
    public void Restart()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        SceneManager.LoadScene("Level 1(N)");
    }

    //Loads the main menu
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        GameIsPaused = true;
        SceneManager.LoadScene("mainmenu");
    }

    //Exist the game
    public void ExitGame()
    {
        Debug.Log("Quitting the game...");
        Application.Quit();
    }


    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
}