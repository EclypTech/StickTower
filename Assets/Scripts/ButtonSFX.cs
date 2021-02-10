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


        StartCoroutine(DestroySound());
        
    }
    
    IEnumerator DestroySound()
    {
        yield return new WaitForSeconds(1f);
        
    }
}
