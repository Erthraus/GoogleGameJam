using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PauseMenuScript : MonoBehaviour
{
    public GameObject DarkMenuObj;
    public GameObject SettingsMenuObj;
    public GameObject PauseMenuObj;
    public bool Paused;



void Start()
    {
        Paused = false;
        DarkMenuObj.SetActive(false);
        SettingsMenuObj.SetActive(false);
        PauseMenuObj.SetActive(false);
    }

void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Paused == false)
                EscButtonPause();

            else if (Paused == true)
                EscButtonResume();
        }
    }

public void ResumeButton()
    {
        Paused = false;
        Time.timeScale = 1.0f;
        DarkMenuObj.SetActive(false);
        SettingsMenuObj.SetActive(false);
        PauseMenuObj.SetActive(false);
    } 


public void EscButtonPause()
    {
            Paused = true;
            Time.timeScale = 0.0f;
            DarkMenuObj.SetActive(true);
            PauseMenuObj.SetActive(true);
    }

public void EscButtonResume()
    {
        Paused = false;
        Time.timeScale = 1.0f;
        DarkMenuObj.SetActive(false);
        SettingsMenuObj.SetActive(false);
        PauseMenuObj.SetActive(false);
    }

public void SettingsButton()
    {
        PauseMenuObj.SetActive(false);
        SettingsMenuObj.SetActive(true);
    }

public void BackButton()
    {
        PauseMenuObj.SetActive(true);
        SettingsMenuObj.SetActive(false);
    }


}
