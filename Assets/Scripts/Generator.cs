using UnityEngine;


public class Generator : MonoBehaviour
{
    public GameObject platformPrefab;                 // Define our game object platform prefab now.
    public float rangeX = 2.5f;                       // Horizontal Range. 
    public float rangeY = 1.5f;                       // Lower limit of Y.
    public int num = 10;                              // Num = 3 for limit of the spawn number.
    public int score = 0;                             // Score = 0 which means number of climbed platforms.
    public Vector3 spawnPosition = new Vector3();     // Create new vector to determine spawn points.


    void Start()                        // When start..
    {
        spawnPosition.y = -3;

        for(int i = 0 ;i < 10 ; i++)
        {
            GeneratorGeneral();         // Run Platform Generator at the beginning.(line34)
        }
    }


    void Update()                       // Update contiuously..
    {
        if (score+10 == num)            // If score equal to limit of the spawn number..
        {
            //if(score == 20 && num == 30)
            //{
            //    rangeY += 0.5f;
            //}


            num += 1;                   // Add 3 more spawn number.
            GeneratorGeneral();         // Run Platform Generator.(line34)
            GameObject.Find("Platform_Basic").GetComponent<BoxCollider2D>().enabled = true; 
            // Colliders are turned off in the counter.cs file to increase the score 1 point each time. It opens again here.
        }
    }


    public void GeneratorGeneral()      // Platform Generator Function.
    {
        spawnPosition.y += Random.Range(rangeY, rangeY);                        // Define random vertical position between minY and maxY.
        spawnPosition.x = Random.Range(-rangeX, rangeX);                        // Define random horizontal position between max and min level width.
        Instantiate(platformPrefab, spawnPosition, Quaternion.identity);        // Spawn platformPrefab take as basis spawn position.
    }
}
