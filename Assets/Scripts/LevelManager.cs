using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public Text levelText;
    public int neededXp = 500;
    public int playerLevel = 1;
    public LevelBar levelBar;


    void Start()
    {
        Load();


    }
  

    public void Load()
    {

        PlayerPrefs.GetInt("neededXp");
        PlayerPrefs.GetInt("playerLevel");

    }

    public void Save()
    {

        PlayerPrefs.SetInt("neededXp", neededXp);
        PlayerPrefs.SetInt("playerLevel", playerLevel);
    }



}
