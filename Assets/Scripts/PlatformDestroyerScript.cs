using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDestroyerScript : MonoBehaviour
{
    public GameObject PlatformDestroyerPoint; // Define Game object.

    void Start()
    {
        PlatformDestroyerPoint = GameObject.Find("PlatformDestroyerPoint"); 
        //When game start, find destroyer point which means tracking lower from the camera.
    }

    void Update()
    {
        if(transform.position.y < PlatformDestroyerPoint.transform.position.y)
            // If any platform has a lower vertical value from the lower limit of camera..
        {
            Destroy(gameObject); // Destroy the platform.
        }
    }
}
