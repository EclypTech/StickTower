using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XPsystem : MonoBehaviour
{
    public Transform player; // Define player to transform coordinates.
    public Text scoreText;   // Define score text.

    void Start()
    {
        
    }

    void Update()
    {
        scoreText.text = player.position.y.ToString("0"); // Equalize the score text with player vertical coordinate.

        if (player.position.y <= 0)  // If statement for when player coordinate under the 0. (At the beginning)
        {
            scoreText.text = "0";
        }
    }
}
