using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSelect : MonoBehaviour
{
    private int map;
    private int lockCheck;
    [SerializeField] private GameObject buyPanel;
    [SerializeField] private GameObject Lock;
    [SerializeField] private GameObject shopPanel;
    [SerializeField] private GameObject reqPanel;
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
    }

    public void UnlockMap()
    {
        buyPanel.SetActive(true);
    }


    public void UnlockButton()
    {
        var level = PlayerPrefs.GetInt("playerLevel");
        var opal = PlayerPrefs.GetInt("totalOpal");

        if (level >= 7 && opal >= 150)
        {
            opal = opal - 150;
            PlayerPrefs.SetInt("totalOpal", opal);
            Lock.SetActive(false);
            buyPanel.SetActive(false);
            PlayerPrefs.SetInt("graceruthLock", 1);

        }
        else if(level >= 7 && opal<150)
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
            Lock.SetActive(false);
        }
    }


}
