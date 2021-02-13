using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaBar : MonoBehaviour
{
    public Slider slider;    // Stamina bar component.
    public Gradient grad;    // To add gradient color.

    public void SetMaxStamina(int stamina)
    {
        slider.maxValue = stamina;  // Equalize the max stamina to max slider.(100)
        slider.value = stamina;     // Equalize the slider value to the stamina at the beginning.(100)
    }

    public void SetStamina(int stamina)  
    {
        slider.value = stamina;  // Equalize the current stamina to current slider.
    }

    void Start()
    {

    }

    void Update()
    {
        slider.value -= Time.deltaTime*5; // Stamina increasing 5 value in a second.

        if(slider.value <= 0)  // If stamina equal to 0
        {
            GameObject.Find("Player").GetComponent<BoxCollider2D>().enabled = false;  // Close the players collider. So it cant climb anymore and fall.
        }
    }
}
