using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class FileSystem : MonoBehaviour
{
    [Header("Component")]
    public TextMeshProUGUI fileCountText;
    public TextMeshProUGUI fileNameText;
    
    public List<File> files;
    public File core;
    public bool activate;
    public int fileCount;

    public string endScreen;

    public void AddFile(File file)
    {
        files.Add(file);
        SetFileText();
       
    }

    public void PopFile()
    {
        if(files.Count!=0)
        {
            files.RemoveAt(files.Count-1);
        }
        
        if(!files.Contains(core))
        {
            Debug.Log("DIE" + gameObject.name +core.fileName + "NotFound");
            DIE();
        }
        SetFileText();

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
        if (GameObject.FindWithTag("Player") != null) 
        {
            GameObject player = GameObject.FindWithTag("Player");
            if (player.GetComponent<MovementTopDown>() != null)
            {
                player.GetComponent<MovementTopDown>().moveSpeed = 8;
            }
            if (player.GetComponent<WeaponParent>() != null)
            {
                player.GetComponent<WeaponParent>().attackDamage = 1;
                player.GetComponent<BaseAttack>().attackRange = 2.0f;
            }
            for (int i = 0; i < files.Count; i++)
            {
                //Debug.Log(i);
                current = files[i];
                current.Passive();

                if (current.open)
                {
                    current.Active();
                }
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

    private void SetFileText()
    {
        fileCount = files.Count;
        fileCountText.text = files.Count.ToString();
        if (fileCount-1 >= 0)
        {
        fileNameText.text = ("Top File: " + files[fileCount-1].fileName);
        }
        else
        {
            fileNameText.text = ("Top File: " + "None");
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SetFileText();
        ActivateEffects();
    }
}
