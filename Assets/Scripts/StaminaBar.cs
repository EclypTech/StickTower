using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaBar : MonoBehaviour
{
    public Slider slider;
    public Gradient grad;

    public void SetMaxStamina(int stamina)
    {
        slider.maxValue = stamina;
        slider.value = stamina;
    }

    public void SetStamina(int stamina)
    {
        slider.value = stamina;
    }

    void Start()
    {
        
    }

    void Update()
    {
        slider.value -= Time.deltaTime*5;

        if(slider.value <= 0)
        {
            GameObject.Find("Player").GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
