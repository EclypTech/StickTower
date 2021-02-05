using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlayer : MonoBehaviour
{
    public GameObject DestroyerPoint;  // Define Game object.
    public GameObject GameOverCanvas;


    void Start()
    {
        DestroyerPoint = GameObject.Find("DestroyerPoint");
        //When game start, find destroyer point which means tracking lower from the camera.
    }

    void Update()
    {
        if (transform.position.y < DestroyerPoint.transform.position.y)
        // If player has a lower vertical value from the lower limit of camera..
        {
            Destroy(gameObject); // Destroy player.
            GameOverCanvas.SetActive(true);
        }

    }

}
