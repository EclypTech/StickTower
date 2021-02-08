using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    [SerializeField] private GameObject pick;
    [SerializeField] private GameObject grapling;
    [SerializeField] private GameObject machette;
    [SerializeField] private GameObject helmet;

    [SerializeField] private int itemSelectNum;

    // Start is called before the first frame update
    void Start()
    {
        itemSelectNum = PlayerPrefs.GetInt("itemnum");

        if(itemSelectNum == 1)
        {
            GetItem(false, true, false, false);
        }
        else if(itemSelectNum == 2)
        {
            GetItem(false, false, true, false);
        }
        else if(itemSelectNum == 3)
        {
            GetItem(true, false, false, true);
        }
        else
        {
            GetItem(true, false, false, false);
        }
    }

    // Update is called once per frame
    private void GetItem(bool b_Pick , bool b_Grapling, bool b_Machette , bool b_Helmet)
    {
        pick.SetActive(b_Pick);
        grapling.SetActive(b_Grapling);
        machette.SetActive(b_Machette);
        helmet.SetActive(b_Helmet);
    }
}
