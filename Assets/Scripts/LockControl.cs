using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockControl : MonoBehaviour
{
    public GameObject panel;
    public Text itemNameText;
    public Text itemPriceText;
    public Text panelText;
    public string itemName;
    public int itemPrice;
    public int itemNumber;
    
    public void OnClick()
    {
        if(itemNumber == 1)
        {
            PlayerPrefs.SetInt("lockId", 1);
        }
        else if( itemNumber == 2)
        {
            PlayerPrefs.SetInt("lockId", 2);
        }
        else if( itemNumber == 3)
        {
            PlayerPrefs.SetInt("lockId", 3);
        }
        else
        {

        }
        panel.SetActive(true);
        itemName = itemNameText.text;
        itemPrice = int.Parse(itemPriceText.text);
        //panelText.text = "You are about to buy " + itemName + ". Do you want to buy it for " + itemPrice+" Opal ?";
        PlayerPrefs.SetInt("itemNumber", itemNumber);
    }
    

    
}
