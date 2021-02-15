using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSelect : MonoBehaviour
{
    private int map;
    [SerializeField] private GameObject buyPanel;
    // Start is called before the first frame update
    void Start()
    {
       map =  PlayerPrefs.GetInt("mapNum");
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
    }


}
