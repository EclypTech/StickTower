using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaminaGenerator : MonoBehaviour
{
    public GameObject StaminaPrefab;
    public Vector3 StamVec = new Vector3();
    public float rangeX = 2.5f;
    public float rangeY = 12;
    public float controlnum = 0;

    void Start()
    {

    }


    void Update()
    {
        GameObject findplayer = GameObject.Find("Player");
        Generator findgenerator = findplayer.GetComponent<Generator>();

        if (findgenerator.score == controlnum)
        {
            controlnum += 3;
            SpawnStamina();
        }
    }

    public void SpawnStamina()
    {
        GameObject findcam = GameObject.Find("Main Camera");
        StamVec.y = Random.Range(findcam.transform.position.y + rangeY, findcam.transform.position.y + rangeY);
        StamVec.x = Random.Range(-rangeX, rangeX);
        Instantiate(StaminaPrefab, StamVec, Quaternion.identity);
    }
}
