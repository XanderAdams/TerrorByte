using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToStart : MonoBehaviour
{
    public string sceneName;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == ("Player"))
        {
            LoadTarget(sceneName);
        }
    }

    public void LoadTarget(string sceneName)
    {
        if(GameManager.Instance!=null)
        {
            GameObject killMe = GameManager.Instance.gameObject;
            Destroy(killMe);
        }
        SceneManager.LoadScene(sceneName);
    }
}
