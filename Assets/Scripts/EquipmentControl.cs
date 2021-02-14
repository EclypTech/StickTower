using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class EquipmentControl : MonoBehaviour
{
    
    public Button pick;
    public Button grapling;
    public Button machette;
    public Button helmet;
    public int itemnum1;

    // Start is called before the first frame update
    void Start()
    {
        //Checking the selected item
        itemnum1 = PlayerPrefs.GetInt("itemnum");

        //Select the equipment
        Selected(itemnum1);

        //Checking unlocked items
        LockCheck();
        

    }
    //Color changer according to selected item
    public void Selected(int item)
    {
        
        if(item == 0)
        {     
            PlayerPrefs.SetInt("itemnum", 0);

            ChangingColor(Color.yellow, Color.white, Color.white, Color.white);



        }
        else if(item == 1)
        {
            
            PlayerPrefs.SetInt("itemnum", 1);

            ChangingColor(Color.white, Color.yellow, Color.white, Color.white);


        }
        else if (item == 2)
        {
            
            PlayerPrefs.SetInt("itemnum", 2);
            ChangingColor(Color.white, Color.white, Color.yellow, Color.white);

        }
        else
        {
            
            PlayerPrefs.SetInt("itemnum", 3);
            ChangingColor(Color.white, Color.white, Color.white, Color.yellow);
        }
        PlayerPrefs.Save();

    }

    //Unlock Checker function
    void LockCheck()
    {
        var item1 = GameObject.Find("GraplingLock");
        var item2 = GameObject.Find("MachetteLock");
        var item3 = GameObject.Find("DrillLock");

        if (PlayerPrefs.GetInt("grapling") == 1)
            item1.SetActive(false);
        if (PlayerPrefs.GetInt("machette") == 1)
            item2.SetActive(false);
        if (PlayerPrefs.GetInt("helmet") == 1)
            item3.SetActive(false);

    }

    //Color changing function
    private void ChangingColor(Color a, Color b, Color c, Color d)
    {
        ColorBlock colorBlockPick = pick.GetComponent<Button>().colors;
        colorBlockPick.normalColor = a;
        pick.GetComponent<Button>().colors = colorBlockPick;

        ColorBlock colorBlockGrapling = grapling.GetComponent<Button>().colors;
        colorBlockGrapling.normalColor = b;
        grapling.GetComponent<Button>().colors = colorBlockGrapling;

        ColorBlock colorBlockMachette = machette.GetComponent<Button>().colors;
        colorBlockMachette.normalColor = c;
        machette.GetComponent<Button>().colors = colorBlockMachette;

        ColorBlock colorBlockHelmet = helmet.GetComponent<Button>().colors;
        colorBlockHelmet.normalColor = d;
        helmet.GetComponent<Button>().colors = colorBlockHelmet;

    }
}   

    


   
