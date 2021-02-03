using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    /*public EnergyBar energyBar;

    public int maxEnergy = 25;

    public int currentEnergy;

    public int worked;

    public int changeSceneTo = 1;

    public GameObject VideoPanel;


    // Start is called before the first frame update
    void Start()
    {
        worked = PlayerPrefs.GetInt("worked");

        if (worked == 0)
        {
            PlayerPrefs.SetInt("currentEnergy", maxEnergy);
            PlayerPrefs.SetInt("worked", 1);
            currentEnergy = PlayerPrefs.GetInt("currentEnergy");
        }
        else
        {
            currentEnergy = PlayerPrefs.GetInt("currentEnergy");
        }
        Debug.Log(PlayerPrefs.GetInt("currentEnergy"));
        energyBar.SetEnergy(currentEnergy);

    }

    public void TakeEnergy()
    {
        if (currentEnergy >= 5)
        {
            currentEnergy -= 5;
            SetCurrentEnergy();
            energyBar.SetEnergy(currentEnergy);
            ChangeScene(changeSceneTo);
        }
        else
        {
            VideoPanel.SetActive(true);
            Debug.Log("Git video izle kopek");
        }
        
        

    }

    void SetCurrentEnergy()
    {
        PlayerPrefs.SetInt("currentEnergy", currentEnergy);
        
    }

    void ChangeScene(int sceneId)
    {
        SceneManager.LoadScene(sceneId);
        
    }
        
    public void GiveEnergy() {

        currentEnergy += 5;
        energyBar.SetEnergy(currentEnergy);
        SetCurrentEnergy();
        VideoPanel.SetActive(false);

    }*/

    

}
