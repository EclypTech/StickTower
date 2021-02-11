using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResumeCountDown : MonoBehaviour
{
    public float countDown = 3;

    public Text countDownText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(countDown > 1)
        {   Time.timeScale = 0;
            countDownText.text = ((int)countDown).ToString();
            countDown -= Time.unscaledDeltaTime;
        }
        else
        {
            Time.timeScale = 1;
            Destroy(gameObject);
        }
        
    }
}
