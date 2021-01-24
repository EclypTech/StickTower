using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour  // WHY WE HAVE THIS CLASS..(CAN WE COMBINE WITH THE STAMINA BAR??)
{
    public int maxStamina = 100;  // Determine max stamina.
    public int currentStamina;   // Determine current stamina.
    public StaminaBar staminaBar;  // Determine stamina bar.


    void Start()
    {
        currentStamina = maxStamina;              //Max stamina equal to 100.
        staminaBar.SetMaxStamina(maxStamina);     //Stamina equal to max stamina at the beggining of game.
    }

    void Update()
    {

    }
}
