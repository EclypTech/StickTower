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
    public int resCheck;
    public int doubleCheck;
    private int opalCount;
    [SerializeField] private GameObject showAdd;
    [SerializeField] private GameObject doubleOpal;

    void Start()
    {
        Time.timeScale = 0f;
        resCheck = PlayerPrefs.GetInt("onemorechance");
        doubleCheck = PlayerPrefs.GetInt("doubleOpal");
        opalCount = PlayerPrefs.GetInt("totalOpal");
        xpSystem = GameObject.FindGameObjectWithTag("XP").GetComponent<XPsystem>().scoreText;
        opalSystem = GameObject.FindGameObjectWithTag("Opal").GetComponent<OpalSystem>().OpalscoreText;

        if(resCheck == 0)
        {
            showAdd.SetActive(true);

        }
        else
        {
            showAdd.SetActive(false);
        }

        if (doubleCheck == 0)
        {
            doubleOpal.SetActive(true);

        }
        else
        {
            doubleOpal.SetActive(false);
            
        }



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
        PlayerPrefs.SetInt("onemorechance", 1);
    }

    public void DoubleOpal()
    {
        newOpalScore = 2 * int.Parse(opalSystem.text);
        newOpalScoreText.text = newOpalScore.ToString();
        opalCount = opalCount + int.Parse(opalSystem.text);
        PlayerPrefs.SetInt("totalOpal", opalCount);
        doubleOpal.SetActive(false);
        showAdd.SetActive(false);



    }
}
