using UnityEngine;


public class Generator : MonoBehaviour
{
    public GameObject platformPrefab;   // Define our game object platform prefab now.
    public int numberOfPlatforms = 5;   // Number of spawn platform component.
    public float levelWidth = 2.5f;     // Horizontal Range. 
    public float minY = 1.3f;           // Lower limit of Y.
    public float maxY = 1.3f;           // Upper limit of Y.
    public Vector3 ye = new Vector3();  // New vector that records the spawn coordinate.
    public int num = 5;                 // Num = 3 for limit of the spawn number.
    public int score = 0;               // Score = 0 which means number of climbed platforms.
    public int OpalNum = 0;


    public GameObject StaminaPrefab;    // Define StaminaPrefab to the script. 
    public int staminaRange = 18;        // Stamina generate range. Must be a multiple of 3

    public GameObject OpalPrefab;       // Define OpalPrefab to the script.
    public int OpalRange = 93;           // Opal generate range. Must be a multiple of 3. BUT shouldnt be multiple of Staminarange.



    void Start()                        // When start..
    {
        GeneratorGeneral();             // Run Platform Generator at the beginning.(line34)
    }

    void Update()                       // Update contiuously..
    {
        if (score == num)               // If score equal to limit of the spawn number..
        {
            num += 5;                   // Add 3 more spawn number.
            GeneratorGeneral();         // Run Platform Generator.(line34)
            GameObject.Find("Platform_Basic").GetComponent<BoxCollider2D>().enabled = true; 
            // Colliders are turned off in the counter.cs file to increase the score 1 point each time. It opens again here.
        }
    }

    public void GeneratorGeneral()      // Platform Generator Function.
    {

        Vector3 spawnPosition = new Vector3();     // Create new vector to determine spawn points.
        spawnPosition.y = ye.y;                    // Our other vector to store spawn points.



        for (int i = 0; i < numberOfPlatforms; i++)  // Loop for create platforms take as basis numberOfPlatforms.
        {
            spawnPosition.y += Random.Range(minY, maxY);                         // Define random vertical position between minY and maxY.
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);             // Define random horizontal position between max and min level width.
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);     // Spawn platformPrefab take as basis spawn position.
            ye.y = spawnPosition.y;                                              // Update spawn points for next spawns to referance these points.

            if( spawnPosition.y == staminaRange)   // If Platform spawn position equal to stamina range...
            {
                staminaRange += 18;                                                 // Increase stamina spawn position.
                spawnPosition.y += 0.6f;                                            // Stamina spawn under the current platform.
                Instantiate(StaminaPrefab, spawnPosition, Quaternion.identity);     // Spawn staminaprefab.
                spawnPosition.y -= 0.6f;                                            // Increase position again for current platform.
            }

            if (spawnPosition.y == OpalRange)   // If Platform spawn position equal to stamina range...
            {
                OpalRange += 93;                                                  // Increase stamina spawn position.
                spawnPosition.y += 0.6f;                                          // Stamina spawn under the current platform.
                Instantiate(OpalPrefab, spawnPosition, Quaternion.identity);      // Spawn staminaprefab.
                spawnPosition.y -= 0.6f;                                          // Increase position again for current platform.
            }




        }

    }
}
