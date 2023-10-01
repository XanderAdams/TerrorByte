using System.Collections;
using System.Collections.Generic;

using System.IO;
using UnityEngine;


[RequireComponent(typeof(FileHolder))]

public class PickupScript : MonoBehaviour
{

    public FileSystem listfolder;
    public File pickup;
   
        private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Collid");
        if(other.tag == "Player")
        {
            listfolder.AddFile(pickup);
            Destroy(gameObject);
        }   
    }
   void Awake()
    {
        pickup = gameObject.GetComponent<FileHolder>().file;
        listfolder = GameObject.FindWithTag("GameManager").GetComponent<FileSystem>();
    }
}
