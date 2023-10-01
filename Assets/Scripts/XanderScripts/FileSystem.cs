using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FileSystem : MonoBehaviour
{
    public List<File> files;
    public File core;
    public bool activate;

    public string endScreen;

    public void AddFile(File file)
    {
        files.Add(file);
    }

    public void PopFile()
    {
        if(files.Count!=0)
        {
            files.RemoveAt(files.Count-1);
        }
        
        if(!files.Contains(core))
        {
            Debug.Log("DIE");
            DIE();
        }
    }

    public void PrintList()
    {
        for(int i = 0; i < files.Count; i++)
        {
            Debug.Log(files[i].fileName);
        }
    }

    public void ActivateEffects()
    {
        File current;
        if(gameObject.GetComponent<MovementTopDown>()!=null)
        {
            gameObject.GetComponent<MovementTopDown>().moveSpeed = 0;
        }
        for(int i = 0; i < files.Count; i++)
        {
            Debug.Log(i);
            current = files[i];
            current.Passive();

            if(current.open && activate)
            {
                current.Active();
            }
        }
    }
    // Start is called before the first frame update

    public void DIE()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        SceneManager.LoadScene(endScreen);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ActivateEffects();
    }
}
