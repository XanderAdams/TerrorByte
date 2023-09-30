using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FileSystem : MonoBehaviour
{
    public List<File> files;

    void AddFile(File file)
    {
        files.Add(file);
    }

    void PopFile()
    {
        files.RemoveAt(files.Count-1);
    }

    void PrintList()
    {
        for(int i = 0; i < files.Count; i++)
        {
            Debug.Log(files[i].fileName);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
