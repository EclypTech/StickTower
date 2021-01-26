using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpalSystem : MonoBehaviour
{
    public Text OpalscoreText;   // Define score text.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject playerobj = GameObject.Find("Player");
        OpalGenerator opalnum = playerobj.GetComponent<OpalGenerator>();

        OpalscoreText.text = opalnum.OpalNum.ToString(); // Equalize text to the score(string).
    }
}
