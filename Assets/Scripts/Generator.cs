using UnityEngine;


public class Generator : MonoBehaviour
{
    public GameObject platformPrefab;

    public int numberOfPlatforms = 5;
    public float levelWidth = 2.7f;
    public float minY = 1.5f;
    public float maxY = 1.5f;
    public Vector3 ye = new Vector3();
    public int num = 3;
    public int score = 0;


    void Start()
    {
        GeneratorGeneral();
    }

    void Update()
    {
        if (score == num)
        {
            num += 3;
            GeneratorGeneral();
            GameObject.Find("Platform_Basic(Clone)").GetComponent<BoxCollider2D>().enabled = true; 

        }

    }

    public void GeneratorGeneral()
    {

        Vector3 spawnPosition = new Vector3();
        spawnPosition.y = ye.y;

        for (int i = 0; i < numberOfPlatforms; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
            ye.y = spawnPosition.y;
            
        }

    }
}
