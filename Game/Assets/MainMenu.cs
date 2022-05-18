using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Level_0");
    }

    // Update is called once per frame
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    

    public void QuitGame()
    {
        Application.Quit();
    }

    public void RetryGame()
    {
        SceneManager.LoadScene("Level_0");
    }
}
