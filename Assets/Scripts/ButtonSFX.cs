using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSFX : MonoBehaviour
{
    public AudioSource buttonSFX;
    public AudioClip clickSFX;
    public AudioClip MapSFX;

    public void ButtonSound()
    {
        buttonSFX.PlayOneShot(clickSFX); 
        
    }

    public void MapSound()
    {
        buttonSFX.PlayOneShot(MapSFX);
    }
    
}
