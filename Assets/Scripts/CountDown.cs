using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDown : MonoBehaviour
{
    public float countDown = 5;

    public Text countDownText;

    private int SceneId = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(countDown > 0)
        {
            countDown -= Time.unscaledDeltaTime;
            countDownText.text = ((int)countDown).ToString();
        }
        else
        {
            Time.timeScale = 1f;
            GoToMenu(SceneId);
        }
    }
    

    void GoToMenu(int SceneId)
    {
        SceneManager.LoadScene(SceneId);
    }
}
