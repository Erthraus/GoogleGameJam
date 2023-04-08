using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

    public void MainMenuButton()
    {
        SceneManager.LoadScene(0);
    }

    public void ProjectsButton()
    {
        SceneManager.LoadScene(1);
    }

    public void SettingsButton()
    {
        SceneManager.LoadScene(2);
    }

    public void CreditsButton()
    {
        SceneManager.LoadScene(3);
    }

    public void GameMenuButton()
    {
        SceneManager.LoadScene(4);
    }

    public void NewProjectButton()
    {
        SceneManager.LoadScene(5);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
