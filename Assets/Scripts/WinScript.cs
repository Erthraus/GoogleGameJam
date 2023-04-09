using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{
    public GameObject DarkMenuObj;
    public GameObject WinMenuObj;
    public bool Paused;


    private Scene _scene;
    private void Awake()
    {
        _scene = SceneManager.GetActiveScene();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Paused = true;
            Time.timeScale = 0.0f;
            DarkMenuObj.SetActive(true);
            WinMenuObj.SetActive(true);
        }

    }
}
