using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFile : File
{
    
    public float baseSpeed;

    public override void Passive()
    {
        Debug.Log("Passive");
        if(GameObject.FindWithTag("Player").GetComponent<MovementTopDown>()!=null)
        {
            GameObject.FindWithTag("Player").GetComponent<MovementTopDown>().moveSpeed = baseSpeed;
        }
    
    }
}
