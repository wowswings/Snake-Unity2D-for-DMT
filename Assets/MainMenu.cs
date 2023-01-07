using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("SnakeUnity2D");
    }

    public void ExitGame()
    {
        Debug.Log("Game quit");
        Application.Quit();
    }
}
