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
        maxStat = 1;
        if (CurrentLevel > maxStat)
        {
            levelCounterNum += (CurrentLevel - maxStat);
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
    }


    public void Save()
    {
        PlayerPrefs.SetInt("levelCounterNum" , levelCounterNum);
        PlayerPrefs.SetInt("maxStat" , maxStat);
        PlayerPrefs.Save();
    }



}
