using System.Collections;
using System.Collections.Generic;

using System.IO;
using UnityEngine;


[RequireComponent(typeof(File))]

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
            gameObject.SetActive(false);
        }   
    }
   void Awake()
    {
        pickup = gameObject.GetComponent<File>();
    }
}