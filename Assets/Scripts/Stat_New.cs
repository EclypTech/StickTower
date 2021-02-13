using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stat_New : MonoBehaviour
{
    public Text StatText;
    public int levelCounterNum;
    public int maxStat = 1;
    public int CurrentLevel;

    public int JumpStarCounter;
    public int MoveStarCounter;
    public int StaminaStarCounter;

    public GameObject[] JumpStarObj;
    public GameObject[] MoveStarObj;
    public GameObject[] StamStarObj;

    public GameObject RecyPanel;

    void Start()
    {
        Load();

        JumpLoop();
        MoveLoop();
        StaminaLoop();
    }

    void Update()
    {
        
    }


    public void JumpButtonTrigger()
    {
        if (levelCounterNum > 0)
        {
            if (JumpStarCounter < 5)
            {
                levelCounterNum -= 1;
                JumpStarCounter += 1;
                StatText.text = levelCounterNum.ToString();
                JumpLoop();
                Save();
            }
        }
    }

    public void MoveButtonTrigger()
    {
        if (levelCounterNum > 0)
        {
            if (MoveStarCounter < 5)
            {
                levelCounterNum -= 1;
                MoveStarCounter += 1;
                StatText.text = levelCounterNum.ToString();
                MoveLoop();
                Save();
            }
        }
    }

    public void StaminaButtonTrigger()
    {
        if (levelCounterNum > 0)
        {
            if (StaminaStarCounter < 5)
            {
                levelCounterNum -= 1;
                StaminaStarCounter += 1;
                StatText.text = levelCounterNum.ToString();
                StaminaLoop();
                Save();
            }
        }
    }


    public void Load()
    {
        levelCounterNum = PlayerPrefs.GetInt("levelCounterNum");
        maxStat = PlayerPrefs.GetInt("maxStat");
        StatText.text = levelCounterNum.ToString();
        CurrentLevel = PlayerPrefs.GetInt("CurrentLevel");

        JumpStarCounter = PlayerPrefs.GetInt("JumpStarCounter");
        MoveStarCounter = PlayerPrefs.GetInt("MoveStarCounter");
        StaminaStarCounter = PlayerPrefs.GetInt("StaminaStarCounter");

    }

    public void Save()
    {
        PlayerPrefs.SetInt("levelCounterNum", levelCounterNum);
        PlayerPrefs.SetInt("maxStat", maxStat);
        PlayerPrefs.SetInt("CurrentLevel", CurrentLevel);

        PlayerPrefs.SetInt("JumpStarCounter", JumpStarCounter);
        PlayerPrefs.SetInt("MoveStarCounter", MoveStarCounter);
        PlayerPrefs.SetInt("StaminaStarCounter", StaminaStarCounter);

        PlayerPrefs.Save();
    }


    public void JumpLoop()
    {
        for (int i = 0; i <= JumpStarCounter - 1; i++)
        {
            JumpStarObj[i].SetActive(false);


        }
    }

    public void MoveLoop()
    {
        for (int i = 0; i <= MoveStarCounter - 1; i++)
        {
            MoveStarObj[i].SetActive(false);
        }
    }

    public void StaminaLoop()
    {
        for (int i = 0; i <= StaminaStarCounter - 1; i++)
        {
            StamStarObj[i].SetActive(false);
        }
    }


    public void RecycleButtonPanel()
    {
        RecyPanel.SetActive(true);  // Open the pause menu.
    }

    public void RecycleStats()
    {
        JumpStarCounter = 0;
        MoveStarCounter = 0;
        StaminaStarCounter = 0;
        levelCounterNum = PlayerPrefs.GetInt("playerLevel");
        StatText.text = levelCounterNum.ToString();

        for (int i = 0; i <= 4; i++)
        {
            JumpStarObj[i].SetActive(true);
        }

        for (int i = 0; i <= 4; i++)
        {
            MoveStarObj[i].SetActive(true);
        }

        for (int i = 0; i <= 4; i++)
        {
            StamStarObj[i].SetActive(true);
        }

        RecyPanel.SetActive(false);

        Save();

    }





}
