using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManag : MonoBehaviour
{
    public Text levelText;
    public int neededXp = 500;
    public int playerLevel = 1;
    public LevelBar levelBar;
    public int xp;
    public int maxXp = 500;

    void Start()
    {
        //PlayerPrefs.SetInt("playerLevel", 7);
        //PlayerPrefs.SetInt("totalOpal", 2000);

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
                xp = xp - neededXp;
                playerLevel++;
                maxXp = maxXp * playerLevel;
                neededXp = maxXp;
                levelText.text = playerLevel.ToString();
                Save();
            }
            levelBar.SetMaxXp(maxXp);
            levelBar.SetXp(xp);
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
