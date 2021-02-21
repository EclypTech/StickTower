using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MapSelect : MonoBehaviour
{
    private int map;
    private int mapInt;
    private int lockCheck;
    private int levelBorder;
    private int cost;
    private string prefName;

    [SerializeField] private GameObject buyPanel;
    [SerializeField] private GameObject iceLock;
    [SerializeField] private GameObject pyramidLock;
    [SerializeField] private GameObject shopPanel;
    [SerializeField] private GameObject reqPanel;

    [SerializeField] private TextMeshProUGUI levelText;
    [SerializeField] private TextMeshProUGUI opalText;

    // Start is called before the first frame update
    void Start()
    {
        
        map =  PlayerPrefs.GetInt("mapNum");
        UnlockCheck();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectMap(int mapNum )
    {
        if(mapNum == 0)
        {
            PlayerPrefs.SetInt("mapNum", mapNum);
        }
        else if(mapNum == 1)
        {
            PlayerPrefs.SetInt("mapNum", mapNum);
        }
        else if(mapNum == 2)
        {
            PlayerPrefs.SetInt("mapNum", mapNum);
        }
        else if (mapNum == 3)
        {
            PlayerPrefs.SetInt("mapNum", mapNum);
        }
    }

    public void UnlockMap(int mapNum)
    {
        if (mapNum == 1)
        {
            levelBorder = 7;
            cost = 150;
            prefName = "graceruthLock";
            levelText.text = levelBorder.ToString();
            opalText.text = cost.ToString();
            mapInt = 1;


        }
        else if (mapNum == 2)
        {
            levelBorder = 9;
            cost = 200;
            prefName = "pyramidLock";
            levelText.text = levelBorder.ToString();
            opalText.text = cost.ToString();
            mapInt = 2;
        }
        else if (mapNum == 3)
        {
            levelBorder = 11;
            cost = 250;
            prefName = "lavalbronLock";
            levelText.text = levelBorder.ToString();
            opalText.text = cost.ToString();
            mapInt = 3;
        }
        buyPanel.SetActive(true);
    }

    //"graceruthLock"
    public void UnlockButton()
    {
        levelText.text = levelBorder.ToString();
        opalText.text = cost.ToString();
        var level = PlayerPrefs.GetInt("playerLevel");
        var opal = PlayerPrefs.GetInt("totalOpal");

        

        if (level >= levelBorder && opal >= cost)
        {
            opal = opal - cost;
            PlayerPrefs.SetInt("totalOpal", opal);
            if(mapInt == 1)
            {
                iceLock.SetActive(false);
            }
            else if(mapInt == 2)
            {
                pyramidLock.SetActive(false);
            }
            else if(mapInt == 3)
            {
                iceLock.SetActive(false);
            }
            
            buyPanel.SetActive(false);
            PlayerPrefs.SetInt(prefName, 1);

        }
        else if(level >= levelBorder && opal<cost)
        {
            shopPanel.SetActive(true);
            
        }
        else
        {
            buyPanel.SetActive(false);
            reqPanel.SetActive(true);
        }

    }

    void UnlockCheck()
    {
        if(PlayerPrefs.GetInt("graceruthLock") == 1)
        {
            iceLock.SetActive(false);
        }
        if(PlayerPrefs.GetInt("pyramidLock") == 1)
        {
            pyramidLock.SetActive(false);
        }
    }


}
