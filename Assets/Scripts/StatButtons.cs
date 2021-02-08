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

    GameObject d1 ;
    GameObject b1 ;
    GameObject c1 ;

    public string k1;
    public string si;
    public string la;

    // Start is called before the first frame update
    void Start()
    {
        Load();

        for (int i = 1; i <= StaminaStarCounter; i++)
        {      
             la = "t" + i.ToString();
             c1 = GameObject.Find(la);
             c1.SetActive(false);
        }

        for (int i = 1; i <= JumpStarCounter; i++)
        {
            k1 = "s" + i.ToString();
            d1 = GameObject.Find(k1);
            d1.SetActive(false);

        }

        for (int i = 1; i <= MoveStarCounter; i++)
        {

            si = "m" + i.ToString();
            b1 = GameObject.Find(si);
            b1.SetActive(false);

        }

    }

    // Update is called once per frame
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
        PlayerPrefs.SetInt("levelCounterNum",99);
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
                k1 = "s" + i.ToString();
                d1 = GameObject.Find(k1);
                d1.SetActive(false);
            }
        }
    }

    public void MoveLoop()
    {
        for (int i = 1; i <= MoveStarCounter; i++)
        {
            if (i == MoveStarCounter)
            {
                si = "m" + i.ToString();
                b1 = GameObject.Find(si);
                b1.SetActive(false);
            }
        }
    }


    public void StaminaLoop()
    {
        for (int i = 1; i <= StaminaStarCounter; i++)
        {
            if (i == StaminaStarCounter)
            {
                la = "t" + i.ToString();
                c1 = GameObject.Find(la);
                c1.SetActive(false);
            }
        }
    }
}
