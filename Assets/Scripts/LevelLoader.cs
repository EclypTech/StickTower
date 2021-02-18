using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    public GameObject LoadingScreen;
    public Slider slider;
    private int sceneIndex;
    private int mapNum;
    [SerializeField] private Text loadingValue;
    void Start()
    {
        mapNum = PlayerPrefs.GetInt("mapNum");
        if(mapNum == 1)
        {
            sceneIndex = 7;
        }
        else
        {
            sceneIndex = 2;
        }

        LoadLevel(sceneIndex);
    }

    void Update()
    {
        
    }

    IEnumerator LoadAsynchronously(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        LoadingScreen.SetActive(true);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            loadingValue.text = Mathf.Round(progress * 100).ToString();
            yield return null;
        }
    }


    public void LoadLevel (int sceneIndex)
    {
        StartCoroutine(LoadAsynchronously(sceneIndex));
    }
}
