using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play_Button : MonoBehaviour
{
    public void PlayGame()
    {
       
        SceneManager.LoadScene(sceneName: "Liam_Scene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

