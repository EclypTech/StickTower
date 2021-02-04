using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelBar : MonoBehaviour
{
    public Slider levelSlider;
    


    // Start is called before the first frame update

    public void SetMaxXp(int energy)
    {
        levelSlider.maxValue = energy;
        //slider.value = energy;
    }

    public void SetXp(int energy)
    {
        levelSlider.value = energy;
    }



}
