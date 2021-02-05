using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpalGenerator : MonoBehaviour
{
    public int OpalNum = 0;
    public GameObject OpalPrefab;
    public Vector3 OpalVec = new Vector3();
    public float ranX = 2.5f;
    public float ranY = 12;
    public float contnum = 0;

    void Start()
    {

    }

    void Update()
    {
        GameObject findplayer = GameObject.Find("Player");
        Generator findgenerator = findplayer.GetComponent<Generator>();

        if (findgenerator.score == contnum)
        {
            contnum += 9;
            SpawnStamina();
        }
    }

    public void SpawnStamina()
    {
        GameObject findcam = GameObject.Find("Main Camera");
        OpalVec.y = Random.Range(findcam.transform.position.y + ranY, findcam.transform.position.y + ranY);
        OpalVec.x = Random.Range(-ranX, ranX);
        Instantiate(OpalPrefab, OpalVec, Quaternion.identity);
    }
}
