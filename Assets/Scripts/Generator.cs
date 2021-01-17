using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Generator : MonoBehaviour
{
    public GameObject platformPrefab;

    public int numberOfPlatforms = 50 ;
    public float levelWidth = 100f;
    public float minY = .2f;
    public float maxY = .60f;


    void Start()
    {

        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i< numberOfPlatforms; i++)
        {
            
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
