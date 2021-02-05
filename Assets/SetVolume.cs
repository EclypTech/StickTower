using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;


public class SetVolume : MonoBehaviour
{
    
    public Slider slider;
    public AudioSource audioSource;
    public float musicSettings;
    private int musicCheck = 0;

    private void Start()
    {
        if(musicCheck == 0){
            musicSettings = 1;
            PlayerPrefs.SetInt("musicCheck", 1);
            SetLevel(musicSettings);
            
        }
        else
        {
            
            musicSettings = PlayerPrefs.GetFloat("musicLevel");
            SetLevel(musicSettings);
        }
    }

    public void SetLevel(float sliderValue)
    {
        slider.value = sliderValue;
        audioSource.volume = sliderValue;
        PlayerPrefs.SetFloat("musicLevel", sliderValue);
        PlayerPrefs.Save();

    }




}
    
