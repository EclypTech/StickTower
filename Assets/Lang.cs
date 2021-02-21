using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class Lang : MonoBehaviour
{
    // Start is called before the first frame update
    private int langCheck;

    void Start()
    {
        langCheck = PlayerPrefs.GetInt("langCheck");
        if (langCheck == 0) {

            PlayerPrefs.SetInt("langCheck", 1);
        }
        else
        {
            StartCoroutine(Starting());
        }
        
        
    }

    IEnumerator Starting()
    {
        
        // Wait for the localization system to initialize
        yield return LocalizationSettings.InitializationOperation;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[PlayerPrefs.GetInt("lang")];
    }

}
