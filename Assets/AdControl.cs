using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("onemorechance", 0);
        PlayerPrefs.SetInt("doubleOpal", 0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
