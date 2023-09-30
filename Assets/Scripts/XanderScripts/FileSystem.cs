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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
