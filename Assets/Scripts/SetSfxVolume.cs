using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SetSfxVolume : MonoBehaviour
{
    public Slider slider;
    public AudioSource audioSource;
    public float sfxSettings;
    public int musicCheck = 0;

    private void Start()
    {
        musicCheck = PlayerPrefs.GetInt("musicCheck");
        if (musicCheck == 0)
        {
            sfxSettings = 1;
            PlayerPrefs.SetInt("musicCheck", 1);
            SetSFXLevel(sfxSettings);


        }
        else
        {
            sfxSettings = PlayerPrefs.GetFloat("sfxLevel");
            SetSFXLevel(sfxSettings);
        }
    }

    public void SetSFXLevel(float sliderValue)
    {
        slider.value = sliderValue;
        audioSource.volume = sliderValue;
        PlayerPrefs.SetFloat("sfxLevel", sliderValue);
        PlayerPrefs.Save();
    }
}
