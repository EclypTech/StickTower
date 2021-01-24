using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{

    //Stamina bar part.
    public int maxStamina = 10;
    public int currentStamina;
    public StaminaBar staminaBar;


    void Start()
    {
        currentStamina = maxStamina;              //Max stamina equal to 100.
        staminaBar.SetMaxStamina(maxStamina);     //Stamina equal to max stamina at the beggining of game.
    }

    void Update()
    {

    }
}
