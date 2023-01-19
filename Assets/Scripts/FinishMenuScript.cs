using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishMenuScript : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("Level 1(N)");
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("mainmenu 1");
    }


    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
