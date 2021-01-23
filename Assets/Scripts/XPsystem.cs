using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XPsystem : MonoBehaviour
{
    public Text scoreText;   // Define score text.

    void Start()
    {
        
    }

    void Update()
    {
        GameObject theplayer = GameObject.Find("Player"); // Find player for get generator script.
        Generator generatorScript = theplayer.GetComponent<Generator>();  // Find generator for get score data.

        scoreText.text = generatorScript.score.ToString(); // Equalize text to the score(string).

    }



}
