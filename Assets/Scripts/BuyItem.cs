using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyItem : MonoBehaviour
{
    
    [SerializeField]
    private GameObject panel;
    [SerializeField] private GameObject shopPanel;
    private int itemNum;
    private int itemPrice;
    public void Buy()
    {
        
        itemNum = PlayerPrefs.GetInt("itemNumber");

        if(itemNum == 1)
        {
            itemPrice = 150;
            TakeOpal(itemPrice,"GraplingLock","grapling");
             
        }
        else if(itemNum == 2)
        {
            itemPrice = 250;
            TakeOpal(itemPrice, "MachetteLock", "machette");
        }
        else if(itemNum == 3)
        {
            itemPrice = 350;
            TakeOpal(itemPrice, "DrillLock", "helmet");
            
        }
        else
        {
            
        }

            
    }

    void TakeOpal(int cost,string itemName,string prefName)
    {
        var totalOpal = PlayerPrefs.GetInt("totalOpal");
        if(totalOpal >= cost)
        {
            totalOpal = totalOpal - cost;
            PlayerPrefs.SetInt("totalOpal", totalOpal);
            var item = GameObject.Find(itemName);
            item.SetActive(false);
            PlayerPrefs.SetInt(prefName, 1);
            panel.SetActive(false);
        }
        else
        {
            shopPanel.SetActive(true);
        }
    }

}
