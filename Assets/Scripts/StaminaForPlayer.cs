using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaminaForPlayer : MonoBehaviour  // WHY WE HAVE THIS CLASS..(CAN WE COMBINE WITH THE STAMINA BAR??)
{
    public int maxStamina;  // Determine max stamina.
    public int currentStamina;   // Determine current stamina.
    public StaminaBar staminaBar;  // Determine stamina bar.

    public int StaminaStarCounter;


    void Start()
    {
        Load();
        maxStamina = 100 + StaminaStarCounter*5;
        currentStamina = maxStamina;              //Max stamina equal to 100.
        staminaBar.SetMaxStamina(maxStamina);     //Stamina equal to max stamina at the beggining of game.

        Save();
    }

    void Update()
    {

    }


    void Save()
    {
        PlayerPrefs.SetInt("StaminaStarCounter", StaminaStarCounter);
        PlayerPrefs.SetFloat("slider.maxValue", maxStamina);
    }

    void Load()
    {
        StaminaStarCounter = PlayerPrefs.GetInt("StaminaStarCounter");
        maxStamina = PlayerPrefs.GetInt("maxStamina");
    }




}
