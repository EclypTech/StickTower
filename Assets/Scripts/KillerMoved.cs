using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillerMoved : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("1");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)  // When touch..
    {
        //amk
        Debug.Log("2");
        if(collision.transform.tag == "MovPlat")
        {
            Debug.Log("3");
            Destroy(gameObject);
        }
    }
}