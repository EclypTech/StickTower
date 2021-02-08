using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemSelect : MonoBehaviour
{

    public GameObject sceneController;
    public int itemnum;
    // Start is called before the first frame update

    // Update is called once per frame
    public void Click()
    {
        PlayerPrefs.SetInt("itemnum", itemnum);
        sceneController.GetComponent<EquipmentControl>().Selected(itemnum);
    }
}
