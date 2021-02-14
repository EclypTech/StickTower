using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    private Text opalSystem;
    private Text xpSystem;
    private GameObject Player;
    public int newScore;
    public int newOpalScore;
    public int newHighScore;

    public Text newScoreText;
    public Text newOpalScoreText;
    public Text newHighScoreText;
    public Text xpText;
    public Text alertText;
    public int totalXp;
    public int highScore = 0;

    
    void Start()
    {
        Time.timeScale = 0f;
        xpSystem = GameObject.FindGameObjectWithTag("XP").GetComponent<XPsystem>().scoreText;
        opalSystem = GameObject.FindGameObjectWithTag("Opal").GetComponent<OpalSystem>().OpalscoreText;
        
        GetScores();
        
        
        if (newScore > highScore )
        {
            newHighScoreText.text = newScore.ToString();
            PlayerPrefs.SetInt("highScore", newScore);
            PlayerPrefs.Save();
            alertText.gameObject.SetActive(true);
        }
        else
        {
            newHighScoreText.text = PlayerPrefs.GetInt("highScore").ToString();
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
        newScore = int.Parse(xpSystem.text);
        newOpalScore = int.Parse(opalSystem.text);
        

        newOpalScoreText.text = newOpalScore.ToString();
        newScoreText.text = newScore.ToString();
        highScore = PlayerPrefs.GetInt("highScore");
        
    }


    void XpCalculator()
    {
        totalXp = newScore * 13;   
    }

    public void OneChance()
    {
      
       GameObject.Find("Player").GetComponent<DestroyPlayer>().OneMoreChance();
    }
}
