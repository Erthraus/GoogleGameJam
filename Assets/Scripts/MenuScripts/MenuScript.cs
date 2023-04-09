using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void MainMenuButton()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void ProjectsButton()
    {
        SceneManager.LoadScene("MM-Projects");
    }

    public void SettingsButton()
    {
        SceneManager.LoadScene("MM-Settings");
    }

    public void CreditsButton()
    {
        SceneManager.LoadScene("MM-Credits");
    }

    public void GameMenuButton()
    {
        SceneManager.LoadScene("Game Menu");
    }

    public void NewProjectButton()
    {
        SceneManager.LoadScene("In-Game");
    }

    public void SceneSelectButton()
    {
        SceneManager.LoadScene("Scene Select Menu");
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
