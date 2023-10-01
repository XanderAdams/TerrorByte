using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class FileCount : MonoBehaviour
{
    public static FileCount instance;
    TextMeshProUGUI fileText;
    public int count;
    
        private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        UpdateFile();
    }

    public void UpdateFile()
    {
        count = gameObject.GetComponent<FileSystem>().files.Count;
        fileText.text = "File Count:" + count;
        fileText.gameObject.GetComponent<SpriteRenderer>().sprite = gameObject.GetComponent<FileSystem>().files[gameObject.GetComponent<FileSystem>().files.Count - 1].fileSprite;
        //fileText.gameObject.GetComponent<SpriteRenderer>().color = gameObject.GetComponent<FileSystem>().files[gameObject.GetComponent<FileSystem>().files.Count - 1].newColor;
    }
}
