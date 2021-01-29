using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovedGenerator : MonoBehaviour
{
    public GameObject PlatformMoved;
    public float PosX = 0;
    public Vector3 MovedCoord = new Vector3();
    public float CountNum = 12;


    public GameObject findplayer;
    public Generator findgenerator;

    void Start()
    {

    }

    void Update()
    {

        findplayer = GameObject.Find("Player");
        findgenerator = findplayer.GetComponent<Generator>();

        if (findgenerator.spawnPosition.y == CountNum)
        {
            CountNum += 3*findgenerator.rangeY ;
            MovedSPawner();
        }
    }

    public void MovedSPawner()
    {
        //findplayer = GameObject.Find("Player");
        //findgenerator = findplayer.GetComponent<Generator>();

        MovedCoord.y = findgenerator.spawnPosition.y;
        MovedCoord.x = PosX;
        Instantiate(PlatformMoved, MovedCoord, Quaternion.identity);
    }
}
