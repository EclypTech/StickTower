using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetPrice : MonoBehaviour
{
    private int itemnum;
    public string itemName;
    public string itemPrice;
    
    [SerializeField] private Text rocket;
    [SerializeField] private Text machete;
    [SerializeField] private Text helmet;
    
    // Start is called before the first frame update


    // Update is called once per frame
    public void NamePrice(int num)
    {
        
        if(num == 1)
        {
            itemName = rocket.text;
            itemPrice = "150";
        }
        else if(num == 2)
        {
            itemName = machete.text;
            itemPrice = "250";
        }
        else if(num == 3)
        {
            itemName = helmet.text;
            itemPrice = "350";
        }
        else
        {

        }
        
 
    }
}
