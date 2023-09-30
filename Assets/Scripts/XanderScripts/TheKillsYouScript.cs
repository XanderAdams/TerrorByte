using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheKillsYouScript : MonoBehaviour
{
    private float scan;
    private File target;
    public FileSystem fileSystem;
    public void Scan()
    {
        if (fileSystem.files.Count>0)
        {
                if (fileSystem.files[fileSystem.files.Count-1] != target)
            {
                target = fileSystem.files[fileSystem.files.Count-1];
                scan = 0;
            }
            else
            {
                scan+=1;
            }

            if(scan>=target.size)
            {
                scan = 0;
                fileSystem.PopFile();
            }
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
