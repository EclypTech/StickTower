using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SetMusicVolume : MonoBehaviour
{
    public Slider slider;
    public AudioSource audioSource;
    public float musicSettings;
    public int musicCheck = 0;

    private void Start()
    {
        musicCheck = PlayerPrefs.GetInt("musicCheck");
        if (musicCheck == 0)
        {
            musicSettings = 1;
            
            PlayerPrefs.SetInt("musicCheck", 1);

            SetMusicLevel(musicSettings);
            
        }
        else
        {
            musicSettings = PlayerPrefs.GetFloat("musicLevel");
            
            SetMusicLevel(musicSettings);  
        }
    }

    public void SetMusicLevel(float sliderValue)
    {
        slider.value = sliderValue;
        audioSource.volume = sliderValue;
        PlayerPrefs.SetFloat("musicLevel", sliderValue);
        PlayerPrefs.Save();

    }

}
