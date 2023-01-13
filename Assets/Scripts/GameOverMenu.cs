using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{

    //Loads the first level
    public void Restart()
    {
        SceneManager.LoadScene("Level 1(N)");
    }

    //Loads the main menu
    public void LoadMenu()
    {
        SceneManager.LoadScene("mainmenu");
    }

    //Exist the game
    public void ExitGame()
    {
        Debug.Log("Quitting the game...");
        Application.Quit();
    }
}