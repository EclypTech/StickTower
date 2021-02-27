using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManag : MonoBehaviour
{
    public Text levelText;
    public int neededXp = 800;
    public int playerLevel = 1;
    public LevelBar levelBar;
    public int xp;
    public int maxXp = 800;

    void Start()
    {
        
        Time.timeScale = 1;
        if (PlayerPrefs.GetInt("maxXp") >= maxXp)
        {
            levelBar.SetMaxXp(PlayerPrefs.GetInt("maxXp"));
            maxXp = PlayerPrefs.GetInt("maxXp");
        }
        else
        {
            levelBar.SetMaxXp(maxXp);
            PlayerPrefs.SetInt("maxXp", maxXp);
            PlayerPrefs.Save();
        }

        //levelBar.SetXp(0);
        Load();
        if (xp < neededXp)
        {
            Debug.Log(neededXp + " needed_if");
            Debug.Log(xp + " xp_if");
            neededXp = neededXp - xp;
            PlayerPrefs.SetInt("neededXp", neededXp);
            PlayerPrefs.SetInt("xp", 0);
            PlayerPrefs.Save();
            levelBar.SetXp(maxXp - neededXp);

        }
        else
        {
            while (xp >= neededXp)
            {
                Debug.Log(neededXp+" needed_while");
                Debug.Log(xp+ " xp_while");
                
                xp = xp - neededXp;
                playerLevel++;
                maxXp = 800 * playerLevel;
                neededXp = maxXp - xp;
                levelText.text = playerLevel.ToString();
                Save();
            }
            PlayerPrefs.SetInt("xp", 0);
            levelBar.SetMaxXp(maxXp);
            levelBar.SetXp(maxXp - neededXp);
        }


    }


    public void Load()
    {
        //maxXp = PlayerPrefs.GetInt("maxXp");
        xp = PlayerPrefs.GetInt("xp");
        neededXp = PlayerPrefs.GetInt("neededXp");
        playerLevel = PlayerPrefs.GetInt("playerLevel");
        levelText.text = playerLevel.ToString();

    }

    public void Save()
    {
        PlayerPrefs.SetInt("maxXp", maxXp);
        PlayerPrefs.SetInt("neededXp", neededXp);
        PlayerPrefs.SetInt("playerLevel", playerLevel);
        PlayerPrefs.Save();
    }
}
