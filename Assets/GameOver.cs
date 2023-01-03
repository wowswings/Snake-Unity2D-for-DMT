using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

    public void ExitGame()
    {
        Debug.Log("Game quit");
        Application.Quit();
    }
}
