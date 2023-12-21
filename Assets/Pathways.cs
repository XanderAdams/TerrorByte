using UnityEngine;
using UnityEngine.SceneManagement;


public class Pathways : MonoBehaviour
{
    public int bufferTime;
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
        // Debug.Log("sceneloader");
            GameManager.Instance.GetComponent<ScanTimer>().currentTime = bufferTime;
            SceneManager.LoadScene(sceneName);
    }
    private void Update()
    {
        GameObject[] gameObjects;
        gameObjects = GameObject.FindGameObjectsWithTag("Enemy");
        

        if (gameObjects.Length == 0)
        {
            gameObject.GetComponent<BoxCollider2D>().enabled = true;
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
            Debug.Log("no emeny left");

        }
    }



}





