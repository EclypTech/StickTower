using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Generator : MonoBehaviour
{
    public GameObject platformPrefab;

    public int numberOfPlatforms = 5 ;
    public float levelWidth = 100f;
    public float minY = .2f;
    public float maxY = .60f;
    public Vector3 ye = new Vector3();


    void Start()
    {
        GeneratorGeneral();


    }

    void Update()
    {
        if (GetComponentInChildren<MyScript>().score == 5)
        {
            Debug.Log("yarak");
            GeneratorGeneral();
        }
    }

    public void GeneratorGeneral()
    {

        Vector3 spawnPosition = new Vector3();
        spawnPosition.y = ye.y;
        Debug.Log("kürek");
        for (int i = 0; i < numberOfPlatforms; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
            ye.y = spawnPosition.y; 
        }

    }
}
