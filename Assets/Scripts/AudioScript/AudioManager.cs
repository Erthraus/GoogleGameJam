using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance = null;

    public AudioSource[] sfx;
    public AudioSource MainMusic;

    public static AudioManager Instance
    {
        get { return instance; }
    }
    private void Awake()
    {
        if (instance != null && instance !=this)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);

    }
    private void Start()
    {
        AudioManager.instance.MainMusic.Stop();
        AudioManager.instance.MainMusic.Play();
    }
    public void PlaySFX(int sfxtoplay)
    {
        sfx[sfxtoplay].Stop();
        sfx[sfxtoplay].Play();
            
    }
}
