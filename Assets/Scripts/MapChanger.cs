using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class MapChanger : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI mountainName;
    [SerializeField] private Image miniMap;
    [SerializeField] private Sprite winderStone;
    [SerializeField] private Sprite gracerath;
    [SerializeField] private Sprite pyramid;
    [SerializeField] private Sprite lava;
    //[SerializeField] private GameObject ices;
    private int mapNum;



    // Start is called before the first frame update
    void Start()
    {
        mapNum = PlayerPrefs.GetInt("mapNum");
        ChangeMap();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeMap()
    {
        if(mapNum == 0)
        {
            //ices.SetActive(false);
            miniMap.sprite = winderStone;
            mountainName.text = "winderStone";
        }
        else if(mapNum == 1)
        {
            miniMap.sprite = gracerath;
//ices.SetActive(true);
            mountainName.text = "graceruth";
        }
        else if (mapNum == 2)
        {
            miniMap.sprite = pyramid;
            //ices.SetActive(false);
            mountainName.text = "Pyramid";
        }
        else if (mapNum == 3)
        {
            miniMap.sprite = lava;
            //ices.SetActive(false);
            mountainName.text = "Lavalbron";
        }
    }
}
