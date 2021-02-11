using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    public AudioSource SFX;
    public AudioClip[] PickClips;
    private float sfxVolume;

    [SerializeField] private AudioClip fallingRock, smashedRock, drink, vulture, vultureDead, landing, rocket, opalCollect, machette,dead;


    private void Start()
    {
        sfxVolume = PlayerPrefs.GetFloat("sfxLevel");
        SFX.volume = sfxVolume;
    }

    public void Pick()
    {
        SFX.PlayOneShot(PickClips[Random.Range(0, PickClips.Length)]);
    }
    public void FallingRock()
    {
        SFX.PlayOneShot(fallingRock);
    }

    public void SmashedRock()
    {
        SFX.PlayOneShot(smashedRock);
    }
    
    public void Drink()
    {
        SFX.PlayOneShot(drink);
    }
    public void Vulture()
    {
        SFX.PlayOneShot(vulture);
    }
    public void VultureDead()
    {
        SFX.PlayOneShot(vultureDead);
    }
    public void Landing()
    {
        SFX.PlayOneShot(landing);
    }
    public void Rocket()
    {
        SFX.PlayOneShot(rocket);
    }
    public void OpalCollect()
    {
        SFX.PlayOneShot(opalCollect);
    }
    public void Machette()
    {
        SFX.PlayOneShot(machette);
    }

    public void Dead()
    {
        SFX.PlayOneShot(dead);
    }
}
