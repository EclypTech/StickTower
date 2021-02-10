using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpalCollector : MonoBehaviour
{
    private int opalCount; // Variable created for total opal number.
    // Start is called before the first frame update
    void Start()
    {
        opalCount = PlayerPrefs.GetInt("totalOpal"); // Total opal calling from prefs.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)  // When touch..
    {
        if (collision.transform.tag == "Player")
        {
            GameObject playerobj = GameObject.Find("Player");
            OpalGenerator opalnum = playerobj.GetComponent<OpalGenerator>();
            opalnum.OpalNum += 1;
            opalCount += 1; // added score to total opal number.
            PlayerPrefs.SetInt("totalOpal", opalCount);// adding the new total number to prefs.
            GameObject SFX = GameObject.Find("SFX");
            SFX.GetComponent<SoundEffects>().OpalCollect();
            Destroy(gameObject);
        }
    }
}
