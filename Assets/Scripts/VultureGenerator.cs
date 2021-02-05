using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VultureGenerator : MonoBehaviour
{
    public GameObject VulturePrefab;
    public Vector3 VultureVec = new Vector3();
    public float ranX = 2.5f;
    public float ranY = 10;
    public float cnum = 50;

    void Start()
    {

    }

    void Update()
    {
        GameObject findplayer = GameObject.Find("Player");
        Generator findgenerator = findplayer.GetComponent<Generator>();

        if (findgenerator.score == cnum)
        {
            cnum += 20;
            SpawnVulture();
        }
    }

    public void SpawnVulture()
    {
        GameObject findcam = GameObject.Find("Main Camera");
        VultureVec.y = Random.Range(findcam.transform.position.y + ranY, findcam.transform.position.y + ranY);
        VultureVec.x = Random.Range(-ranX, ranX);
        Instantiate(VulturePrefab, VultureVec, Quaternion.identity);
    }
}
