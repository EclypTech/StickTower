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
        GameObject theplayer = GameObject.Find("Player"); // Find player for get generator script.
        Generator generatorScript = theplayer.GetComponent<Generator>();  // Find generator for get score data.

        OpalscoreText.text = generatorScript.OpalNum.ToString(); // Equalize text to the score(string).
    }
}
