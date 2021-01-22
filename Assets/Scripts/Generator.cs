using UnityEngine;


public class Generator : MonoBehaviour
{
    public GameObject platformPrefab;   // Define our game object platform prefab now.
    public int numberOfPlatforms = 5;   // Number of spawn platform component.
    public float levelWidth = 2.5f;     // Horizontal Range. 
    public float minY = 1.3f;           // Lower limit of Y.
    public float maxY = 1.3f;           // Lower limit of Y.
    public Vector3 ye = new Vector3();  // New vector that records the spawn coordinate.
    public int num = 3;                 // Num = 3 for limit of the spawn number.
    public int score = 0;               // Score = 0 which means number of climbed platforms.


    void Start()                        // When start..
    {
        GeneratorGeneral();             // Run Platform Generator at the beginning.(line34)
    }

    void Update()                       // Update contiuously..
    {
        if (score == num)               // If score equal to limit of the spawn number..
        {
            num += 3;                   // Add 3 more spawn number.
            GeneratorGeneral();         // Run Platform Generator.(line34)
            GameObject.Find("Platform_Basic(Clone)").GetComponent<BoxCollider2D>().enabled = true; 
            // Colliders are turned off in the counter.cs file to increase the score 1 point each time. It opens again here.
        }
    }

    public void GeneratorGeneral()      // Platform Generator Function.
    {

        Vector3 spawnPosition = new Vector3();  // Create new vector to determine spawn points.
        spawnPosition.y = ye.y;                 // Our other vector to store spawn points.

        for (int i = 0; i < numberOfPlatforms; i++)  // Loop for create platforms take as basis numberOfPlatforms.
        {
            spawnPosition.y += Random.Range(minY, maxY);    // Define random vertical position between minY and maxY.
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);  // Define random horizontal position between max and min level width.
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity); // Spawn platformPrefab take as basis spawn position.
            ye.y = spawnPosition.y;  // Update spawn points for next spawns to referance these points.
            
        }

    }
}
