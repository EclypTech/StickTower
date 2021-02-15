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
    [SerializeField] private GameObject ices;
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
            ices.SetActive(false);
            miniMap.sprite = winderStone;
            mountainName.text = "winderStone mountain";
        }
        else if(mapNum == 1)
        {
            miniMap.sprite = gracerath;
            ices.SetActive(true);
            mountainName.text = "graceruth mountain";
        }
    }
}
