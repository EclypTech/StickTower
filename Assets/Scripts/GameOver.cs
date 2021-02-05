using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public OpalSystem opalSystem;
    public XPsystem xpSystem;
    public string newScore;
    public string newOpalScore;
    public int newHighScore;

    public Text newScoreText;
    public Text newOpalScoreText;
    public Text newHighScoreText;
    public Text xpText;
    public Text alertText;
    public int totalXp;

    
    void Start()
    {
        Time.timeScale = 0f;
        GetScores();

        if (int.Parse(newScore) > int.Parse(PlayerPrefs.GetString("highScore")))
        {
            newHighScoreText.text = newScore;
            PlayerPrefs.SetString("highScore", newScore);
            PlayerPrefs.Save();
            alertText.gameObject.SetActive(true);
        }
        else
        {
            newHighScoreText.text = PlayerPrefs.GetString("highScore");
            alertText.gameObject.SetActive(false);
        }
        XpCalculator();
        PlayerPrefs.SetInt("xp", totalXp);
        PlayerPrefs.Save();
        xpText.text = totalXp.ToString();
        
    } 

    
    void Update()
    {
        
    }

    void GetScores()
    {
        newScore = xpSystem.scoreText.text;
        newOpalScore = opalSystem.OpalscoreText.text;

        newOpalScoreText.text = newOpalScore;
        newScoreText.text = newScore;
    }


    void XpCalculator()
    {
        totalXp = int.Parse(newScore) * 10;   
    }
}
