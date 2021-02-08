using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager1 : MonoBehaviour
{

    public void ChangeScene(int sceneId)
    {
        SceneManager.LoadScene(sceneId);
    }

}


