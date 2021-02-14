using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnergyManager : MonoBehaviour
{
    [SerializeField]
    private Text textEnergy;

    [SerializeField]
    private Text textTimer;

   

    //public int totalEnergy;

    private DateTime nextEnergyTime;

    private DateTime lastAddedTime;

    public int restoreDuration = 5;

    public EnergyBar energyBar;

    public int maxEnergy = 25;

    public int currentEnergy;

    public int worked;

    public int changeSceneTo;

    public GameObject VideoPanel;

    // Start is called before the first frame update
    void Start()
    {
        worked = PlayerPrefs.GetInt("worked"); // when the first run "worked" return 0 

        if (worked == 0)
        {
            PlayerPrefs.SetInt("currentEnergy", maxEnergy); // On the first opening current energy set to the maximum energy
            worked = 1;
            PlayerPrefs.SetInt("worked", worked); // After the settings "worked" setting to 1
            PlayerPrefs.Save();
            currentEnergy = PlayerPrefs.GetInt("currentEnergy"); //current energy calling from prefs for equalizing
            energyBar.SetEnergy(currentEnergy);
        }
        else
        {
            currentEnergy = PlayerPrefs.GetInt("currentEnergy"); //if it is not the first opening, current energy getting from prefs.
            energyBar.SetEnergy(currentEnergy);
        }
        
         // energy slider equalizing to current energy (SetEnergy() function is in EnergyBar Script)

        Load(); // Loading timer values
        StartCoroutine(RestoreRoutine()); // starting the timer for energy


    }

    private IEnumerator RestoreRoutine()
    {
        UpdateTimer();//Time is setting before the beginning of process.
        UpdateEnergy();//Energy text and bar setting to current value.


        while (currentEnergy < maxEnergy)//if current energy is bigger than maximum value timer dont work
        {
            DateTime curretTime = DateTime.Now;
            
            DateTime counter = nextEnergyTime;
            
            bool isAdding = false;

            while (curretTime > counter) 
            {
                if (currentEnergy < maxEnergy)
                {
                    isAdding = true;
                    currentEnergy += 5;
                    DateTime timeToAdd = lastAddedTime > counter ? lastAddedTime : counter;
                    counter = AddDuration(timeToAdd, restoreDuration);
                }
                else
                    break;
            }

            if (isAdding)
            {
                lastAddedTime = DateTime.Now;
                nextEnergyTime = counter;
            }
            
            UpdateTimer();
            UpdateEnergy();
            Save();


            yield return null;


        }
    }

    private void UpdateTimer()
    {
        if (currentEnergy >= maxEnergy)
        {
            textTimer.text = "";
            return;
        }

        TimeSpan t = nextEnergyTime - DateTime.Now;
        string value = String.Format("{0}:{1:D2}:{2:D2}", (int)t.TotalHours, t.Minutes, t.Seconds);

        textTimer.text = value;
    }

    private void UpdateEnergy()
    {
        currentEnergy = PlayerPrefs.GetInt("currentEnergy");
        textEnergy.text = currentEnergy.ToString();
        energyBar.SetEnergy(currentEnergy);
    }

    private DateTime AddDuration(DateTime time, int duration)
    {
        return time.AddMinutes(duration);
    }


    public void Load()
    {
        //currentEnergy = PlayerPrefs.GetInt("currentEnergy");
        nextEnergyTime = StringToDate(PlayerPrefs.GetString("nextEnergyTime"));
        lastAddedTime = StringToDate(PlayerPrefs.GetString("lastAddedTime"));
    }
    public void Save()
    {
        PlayerPrefs.SetInt("currentEnergy", currentEnergy);
        PlayerPrefs.SetString("nextEnergyTime", nextEnergyTime.ToString());
        PlayerPrefs.SetString("lastAddedTime", lastAddedTime.ToString());

    }

    private DateTime StringToDate(string date)
    {
        if (String.IsNullOrEmpty(date))
        {
            return DateTime.Now;

        }
        return DateTime.Parse(date);

    }

    public void TakeEnergy()
    {
        if (currentEnergy >= 5)
        {
            currentEnergy -= 5;
            SetCurrentEnergy();
            energyBar.SetEnergy(currentEnergy);
            textEnergy.text = currentEnergy.ToString();
            ChangeScene(changeSceneTo);
        }
        else
        {
            VideoPanel.SetActive(true);
            Debug.Log("Git video izle kopek");
        }
    }

    void SetCurrentEnergy() // Easy way to set current energy pref.
    {
        PlayerPrefs.SetInt("currentEnergy", currentEnergy);

    }

    void ChangeScene(int sceneId) // Changing screen to the game play
    {
        SceneManager.LoadScene(sceneId);

    }

    public void GiveEnergy()
    {

        currentEnergy += 5;
        energyBar.SetEnergy(currentEnergy);
        SetCurrentEnergy();
        VideoPanel.SetActive(false);

    }

}

