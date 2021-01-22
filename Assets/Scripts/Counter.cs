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

    private void OnTriggerEnter2D(Collider2D collision) // When triggered Collider..
    {
        if (collision.transform.tag == "Player")               // If triggered collision tag is Player..
        {
            collision.GetComponent<Generator>().score += 1;    // Add 1 point to the score which located Generator.cs
            GetComponent<BoxCollider2D>().enabled = false;     // Close the box collider for increase the score 1 point each time.

        }



    }

}