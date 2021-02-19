using UnityEngine;


public class Generator : MonoBehaviour
{
    public GameObject platformPrefab;                 // Define our game object platform prefab now.

    public GameObject IcePrefab;

    public float rangeX = 2.5f;                       // Horizontal Range. 
    public float rangeY = 1.5f;                       // Lower limit of Y.
    public int num = 10;                              // Num = 3 for limit of the spawn number.
    public int score = 0;                             // Score = 0 which means number of climbed platforms.
    public Vector3 spawnPosition = new Vector3();     // Create new vector to determine spawn points.
    public int movNum = 20;
    public int icenum = 15;

    void Start()                        // When start..
    {
        platformPrefab.GetComponent<MoveDen>().enabled = false;
        spawnPosition.y = -3;

        for (int i = 0 ;i < 10 ; i++)
        {
            GeneratorGeneral();         // Run Platform Generator at the beginning.(line34)

        }
    }


    void FixedUpdate()                       // Update contiuously..
    {
        if ( score == movNum && score <= 50 && score + 10 == num)
        {
            if (score == 30 && num == 40)
            {
                rangeY += 0.5f;
            }

            movNum += 2;
            platformPrefab.GetComponent<MoveDen>().enabled = true;
            num += 1;                   // Add 3 more spawn number.
            GeneratorGeneral();         // Run Platform Generator.(line34)
            platformPrefab.GetComponent<MoveDen>().enabled = false;


        }else if (score >= 50 && score + 10 == num)
        {
            if (score == 70 && num == 80)
            {
                rangeY += 0.5f;
            }

            platformPrefab.GetComponent<MoveDen>().enabled = true;
            num += 1;                   // Add 3 more spawn number.
            GeneratorGeneral();         // Run Platform Generator.(line34)
        }
        else if (score+10 == num)            // If score equal to limit of the spawn number..
        {
            if (score == 30 && num ==40)
            {
                rangeY += 0.5f;
            }


            platformPrefab.GetComponent<MoveDen>().enabled = false;
            num += 1;                   // Add 3 more spawn number.
            GeneratorGeneral();         // Run Platform Generator.(line34)

        }
    }


    public void GeneratorGeneral()      // Platform Generator Function.
    {
        spawnPosition.y += Random.Range(rangeY, rangeY);                        // Define random vertical position between minY and maxY.
        spawnPosition.x = Random.Range(-rangeX, rangeX);                        // Define random horizontal position between max and min level width.
        spawnPosition.z = 1;
        Instantiate(platformPrefab, spawnPosition, Quaternion.identity);        // Spawn platformPrefab take as basis spawn position.
    }

}
