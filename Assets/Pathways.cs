using UnityEngine;
using UnityEngine.SceneManagement;


public class Pathways : MonoBehaviour
{

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == ("Player"))
        {
            Debug.Log("sceneloader");
            SceneManager.LoadScene("GarrettScene");
        }
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





