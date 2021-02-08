using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyItem : MonoBehaviour
{
    /*private int grapling = 1;
    private int machette = 2;
    private int drill = 3;*/
    [SerializeField]
    private GameObject panel;
    private int itemNum;
    public void Buy()
    {
        
        itemNum = PlayerPrefs.GetInt("itemNumber");

        if(itemNum == 1)
        {
            Debug.Log("Grapling Buyed");
            var item = GameObject.Find("GraplingLock");
            item.SetActive(false);
            PlayerPrefs.SetInt("grapling", 1);
        }
        else if(itemNum == 2)
        {
            Debug.Log("Machette Buyed");
            var item = GameObject.Find("MachetteLock");
            item.SetActive(false);
            PlayerPrefs.SetInt("machette", 1);
        }
        else if(itemNum == 3)
        {
            Debug.Log("Drill Buyed");
            var item = GameObject.Find("DrillLock");
            item.SetActive(false);
            PlayerPrefs.SetInt("helmet", 1);
        }
        else
        {
            Debug.Log("Baþaramadýk Abi");
        }

        panel.SetActive(false);

        
            
    }
}
