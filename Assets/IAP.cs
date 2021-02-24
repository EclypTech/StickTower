using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;
using System;
using UnityEngine.UI;

public class IAP : MonoBehaviour
{
    private int totalOpal;

    private string opal100 = "com.everbrosgames.opal.100";
    private string opal250 = "com.everbrosgames.opal.250";
    private string opal500 = "com.everbrosgames.opal.500";
    private string opal1000 = "com.everbrosgames.opal.1000";
    public void OnPurchaseComplete(Product product)
    {
        totalOpal = PlayerPrefs.GetInt("totalOpal");

        if (product.definition.id == opal100)
        {
            totalOpal = totalOpal + 100;
            PlayerPrefs.SetInt("totalOpal", totalOpal);
        }

        else if (product.definition.id == opal250)
        {
            totalOpal = totalOpal + 250;
            PlayerPrefs.SetInt("totalOpal", totalOpal);
        }
        else if (product.definition.id == opal500)
        {
            totalOpal = totalOpal + 500;
            PlayerPrefs.SetInt("totalOpal", totalOpal);
        }
        else if (product.definition.id == opal1000)
        {
            totalOpal = totalOpal + 1000;
            PlayerPrefs.SetInt("totalOpal", totalOpal);
        }


    }

    public void OnPurchaseFailed(Product product,PurchaseFailureReason reason)
    {
        Debug.Log(reason);
    }
    

}
