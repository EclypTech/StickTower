using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpalGenerator : MonoBehaviour
{
    public GameObject OpalPrefab;        // Define OpalPrefab to the script.
    public int OpalRange = 93;           // Opal generate range. Must be a multiple of 3. BUT shouldnt be multiple of Staminarange.
    public int OpalNum = 0; 


    void Start()
    {
        
    }


    void Update()
    {
        GameObject findplayer = GameObject.Find("Player");
        Generator findgenerator = findplayer.GetComponent<Generator>();


        if (findgenerator.spawnPosition.y == OpalRange)   // If Platform spawn position equal to stamina range...
        {
            OpalRange += 93;                                                                // Increase stamina spawn position.
            findgenerator.spawnPosition.y += 0.6f;                                          // Stamina spawn under the current platform.
            Instantiate(OpalPrefab, findgenerator.spawnPosition, Quaternion.identity);      // Spawn staminaprefab.
            findgenerator.spawnPosition.y -= 0.6f;                                          // Increase position again for current platform.
        }
    }

}