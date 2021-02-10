using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSFX : MonoBehaviour
{
    public AudioSource buttonSFX;
    public AudioClip clickSFX;

    public void ButtonSound()
    {
        buttonSFX.PlayOneShot(clickSFX);


        
        
    }
    
}
