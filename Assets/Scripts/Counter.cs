using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Counter : MonoBehaviour
{

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }




    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            collision.GetComponent<Generator>().score += 1;    
            GetComponent<BoxCollider2D>().enabled = false;
        }



    }

}