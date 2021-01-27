using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaminaGenerator : MonoBehaviour
{
    public GameObject StaminaPrefab;    // Define StaminaPrefab to the script. 
    public int staminaRange = 12;        // Stamina generate range. Must be a multiple of 3


    void Start()
    {
        
    }


    void Update()
    {
        GameObject findplayer = GameObject.Find("Player");
        Generator findgenerator = findplayer.GetComponent<Generator>();


        if (findgenerator.spawnPosition.y == staminaRange)   // If Platform spawn position equal to stamina range...
        {
            staminaRange += 12;                                                 // Increase stamina spawn position.
            findgenerator.spawnPosition.y += 0.6f;                                            // Stamina spawn under the current platform.
            Instantiate(StaminaPrefab, findgenerator.spawnPosition, Quaternion.identity);     // Spawn staminaprefab.
            findgenerator.spawnPosition.y -= 0.6f;                                            // Increase position again for current platform.
        }
    }

}
