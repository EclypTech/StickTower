using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;


public class SetVolume : MonoBehaviour
{
    
    public Slider slider;
    public Slider slider1;
    public AudioSource audioSource;
    public float musicSettings;
    public float sfxSettings;
    public int musicCheck = 0;

    private void Start()
    {
        musicCheck = PlayerPrefs.GetInt("musicCheck");
        if(musicCheck == 0){
            musicSettings = 1;
            sfxSettings = 1;
            PlayerPrefs.SetInt("musicCheck", 1);
            
            SetMusicLevel(musicSettings);
            SetSFXLevel(sfxSettings);

            
        }
        else
        {
            
            musicSettings = PlayerPrefs.GetFloat("musicLevel");
            sfxSettings = PlayerPrefs.GetFloat("sfxLevel");
            SetMusicLevel(musicSettings);
            SetSFXLevel(sfxSettings);
        }
    }

    public void SetMusicLevel(float sliderValue)
    {
        slider.value = sliderValue;
        audioSource.volume = sliderValue;
        PlayerPrefs.SetFloat("musicLevel", sliderValue);
        //PlayerPrefs.Save();

    }

    public void SetSFXLevel(float sliderValu)
    {
        slider1.value = sliderValu;
        audioSource.volume = sliderValu;
        PlayerPrefs.SetFloat("sfxLevel", sliderValu);
        //PlayerPrefs.Save();
    }




}
    
