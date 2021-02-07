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
    private string itemName;
    private int itemPrice;
    public int itemNumber;
    
    public void OnClick()
    {
        panel.SetActive(true);
        itemName = itemNameText.text;
        itemPrice = int.Parse(itemPriceText.text);
        panelText.text = "You are about to buy " + itemName + ". Do you want to buy it for " + itemPrice+" Opal ?";
        PlayerPrefs.SetInt("itemNumber", itemNumber);
    }
    

    
}
