using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stat_Counter : MonoBehaviour
{
    public int levelCounterNum;
    public int maxStat = 1;
    public int CurrentLevel;


    void Start()
    {
        Load();
        CurrentLevel = PlayerPrefs.GetInt("playerLevel");
        if (CurrentLevel > maxStat)
        {
            levelCounterNum += (CurrentLevel - maxStat);
            maxStat = levelCounterNum;
            Save();
        }

    }


    void Update()
    {
        
    }


    public void Load()
    {
        levelCounterNum = PlayerPrefs.GetInt("levelCounterNum");
        maxStat = PlayerPrefs.GetInt("maxStat");
        CurrentLevel = PlayerPrefs.GetInt("CurrentLevel");
    }


    public void Save()
    {
        PlayerPrefs.SetInt("levelCounterNum" , levelCounterNum);
        PlayerPrefs.SetInt("maxStat" , maxStat);
        PlayerPrefs.SetInt("CurrentLevel", CurrentLevel);

        PlayerPrefs.Save();
    }



}
