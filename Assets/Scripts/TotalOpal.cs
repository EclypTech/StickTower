using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalOpal : MonoBehaviour
{
    public Text totalOpalCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        totalOpalCount.text = PlayerPrefs.GetInt("totalOpal").ToString();
    }
}
