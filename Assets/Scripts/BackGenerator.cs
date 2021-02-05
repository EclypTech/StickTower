using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGenerator : MonoBehaviour
{
    public float rX = 2.2f;
    public float rY = 7;
    public Vector3 SpawnPos = new Vector3();
    public int num = 1;

    [SerializeField]
    public GameObject[] SpawnObjects;
    private int RandomObj;



    void Start()
    {
        
    }



    void Update()
    {
        GameObject findplayer = GameObject.Find("Player");
        Generator findgenerator = findplayer.GetComponent<Generator>();

        if (findgenerator.score == num)
        {
            num += 1;
            GeneratorBG();
        }
    }

    public void GeneratorBG()
    {
        GameObject findcam = GameObject.Find("Main Camera");
        RandomObj = Random.Range(0, 6);
        SpawnPos.y = findcam.transform.position.y + rY;
        SpawnPos.x = Random.Range(-rX, rX);
        Instantiate(SpawnObjects[RandomObj], SpawnPos, Quaternion.identity);
    }
}
