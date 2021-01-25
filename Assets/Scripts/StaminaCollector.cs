using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaminaCollector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)  // When touch..
    {
        if (collision.transform.tag == "Player")
        {
            GameObject bar = GameObject.Find("StaminaBar");
            StaminaBar staminaScript = bar.GetComponent<StaminaBar>();
            staminaScript.slider.value += 25;
            Destroy(gameObject);
        }
    }



}
