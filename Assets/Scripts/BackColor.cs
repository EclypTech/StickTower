using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackColor : MonoBehaviour
{
    SpriteRenderer sprite;
    float Alpha = 1;
    int ScoreControl = 0;


    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        sprite.color = new Color(169, 105, 49, Alpha);
        ScoreControl = 1;
    }

    void Update()
    {
        GameObject findplayer = GameObject.Find("Player");
        Generator findgenerator = findplayer.GetComponent<Generator>();
        if (ScoreControl == findgenerator.score)
        {
            ScoreControl += 1;
            Alpha -= 0.005f;
            sprite.color = new Color(169, 105, 49, Alpha);
        }

    }
}
