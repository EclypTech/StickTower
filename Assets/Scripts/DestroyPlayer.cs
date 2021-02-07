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
            GameOverCanvas.SetActive(true);
        }

    }

     public void OneMoreChance()
    {
        transform.eulerAngles = new Vector2(0, 0);

        GameObject findnewpos = GameObject.Find("NewPosPlayer");
        transform.position = new Vector3(-1 , findnewpos.transform.position.y + 8 , -1);

        GameObject findstamina = GameObject.Find("StaminaBar");
        StaminaBar findbar = findstamina.GetComponent<StaminaBar>();
        findbar.slider.value = findbar.slider.maxValue;

        Time.timeScale = 1;
        GameOverCanvas.SetActive(false);

    }

}
