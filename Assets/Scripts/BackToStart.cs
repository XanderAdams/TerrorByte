using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToStart : MonoBehaviour
{
    public string sceneName;
    public void LoadTarget()
    {
        GameObject killMe = GameManager.Instance.gameObject;
        Destroy(killMe);
        SceneManager.LoadScene(sceneName);
    }
}
