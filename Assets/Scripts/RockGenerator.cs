using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockGenerator : MonoBehaviour
{
    public GameObject RockPrefab;
    public Vector3 RockVec = new Vector3();
    public float rokX = 2.5f;
    public float rokY = 10;
    public float roknum = 80;
    

    void Start()
    {
        
    }

    void Update()
    {
        GameObject findplayer = GameObject.Find("Player");
        Generator findgenerator = findplayer.GetComponent<Generator>();

        if (findgenerator.score == roknum)
        {
            roknum += 80;
            GameObject SFX = GameObject.Find("SFX");
            SFX.GetComponent<SoundEffects>().FallingRock();
            SpawnRock();
            
        }
    }

    public void SpawnRock()
    {
        GameObject findcam = GameObject.Find("Main Camera");
        RockVec.y = Random.Range(findcam.transform.position.y + rokY, findcam.transform.position.y + rokY);
        RockVec.x = Random.Range(-rokX, rokX);
        Instantiate(RockPrefab, RockVec, Quaternion.identity);
    }
}
