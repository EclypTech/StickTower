using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangePauseButton : MonoBehaviour
{

    public Sprite clickedPauseImg; // New img sourse when press the pause. It means play button.
    public Button Game_Pause;  // Main pause button. Not an img.


    public void ChangeButtonImg() // Change Button function.
    {
        Game_Pause.image.sprite = clickedPauseImg; // Change source img when pressed button.
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
