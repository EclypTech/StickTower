using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatButtons : MonoBehaviour
{
    public Text StatText;
    public int levelCounterNum;
    public int maxStat = 1;
    public int CurrentLevel;

    public int JumpStarCounter;
    public int MoveStarCounter;
    public int StaminaStarCounter;

    GameObject jumpstarobj ;
    GameObject movestarobj ;
    GameObject stamstarobj ;

    public string JumpStr;
    public string moveStr;
    public string staminaStr;

    GameObject RecyPanel;

    void Start()
    {
        Load();

        for (int i = 1; i <= StaminaStarCounter; i++)
        {
             staminaStr = "t" + i.ToString();
             stamstarobj = GameObject.Find(staminaStr);
             stamstarobj.SetActive(false);
        }

        for (int i = 1; i <= JumpStarCounter; i++)
        {
            JumpStr = "s" + i.ToString();
            jumpstarobj = GameObject.Find(JumpStr);
            jumpstarobj.SetActive(false);
        }

        for (int i = 1; i <= MoveStarCounter; i++)
        {
            moveStr = "m" + i.ToString();
            movestarobj = GameObject.Find(moveStr);
            movestarobj.SetActive(false);
        }
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

    public void Load() // silinecek öðe var.
    {
        PlayerPrefs.SetInt("levelCounterNum",99); // deneme için duruyor.
        levelCounterNum = PlayerPrefs.GetInt("levelCounterNum");
        maxStat = PlayerPrefs.GetInt("maxStat");
        StatText.text = levelCounterNum.ToString();

        JumpStarCounter = PlayerPrefs.GetInt("JumpStarCounter");
        MoveStarCounter = PlayerPrefs.GetInt("MoveStarCounter");
        StaminaStarCounter = PlayerPrefs.GetInt("StaminaStarCounter");
    }

    public void Save()
    {
        PlayerPrefs.SetInt("levelCounterNum", levelCounterNum);
        PlayerPrefs.SetInt("maxStat", maxStat);

        PlayerPrefs.SetInt("JumpStarCounter", JumpStarCounter);
        PlayerPrefs.SetInt("MoveStarCounter", MoveStarCounter);
        PlayerPrefs.SetInt("StaminaStarCounter", StaminaStarCounter);

        PlayerPrefs.Save();
    }

    public void JumpLoop()
    {
        for (int i = 1; i <= JumpStarCounter; i++)
        {
            if(i == JumpStarCounter)
            {
                JumpStr = "s" + i.ToString();
                jumpstarobj = GameObject.Find(JumpStr);
                jumpstarobj.SetActive(false);
            }
        }
    }

    public void MoveLoop()
    {
        for (int i = 1; i <= MoveStarCounter; i++)
        {
            if (i == MoveStarCounter)
            {
                moveStr = "m" + i.ToString();
                movestarobj = GameObject.Find(moveStr);
                movestarobj.SetActive(false);
            }
        }
    }

    public void StaminaLoop()
    {
        for (int i = 1; i <= StaminaStarCounter; i++)
        {
            if (i == StaminaStarCounter)
            {
                staminaStr = "t" + i.ToString();
                stamstarobj = GameObject.Find(staminaStr);
                stamstarobj.SetActive(false);
            }
        }
    }

    public void RecycleButtonPanel()
    {
        RecyPanel = GameObject.Find("RecyclePanel");
        RecyPanel.SetActive(true);  // Open the pause menu.
        Time.timeScale = 0f;          // Freeze the time.

    }

    public void RecycleStats()
    {

    }
}
