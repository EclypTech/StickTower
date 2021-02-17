using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ice_Enemy : MonoBehaviour
{
    public GameObject IcePref;
    public int IceEnemyNum = 15 ;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        GameObject plat = GameObject.Find("Player");
        Generator gnrtr = plat.GetComponent<Generator>();

        if (gnrtr.score == IceEnemyNum)
        {
            IcePref.gameObject.SetActive(true);
            IceEnemyNum += 5;

        }
        else
        {
            
        }
    }


}
