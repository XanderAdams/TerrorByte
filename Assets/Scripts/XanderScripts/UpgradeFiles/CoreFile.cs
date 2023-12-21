using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New File", menuName = "UpgradeFile/Core")]
public class CoreFile : File
{

    public int power;
    public int baseSpeed;

    public override void Passive()
    {
        if(GameManager.Instance.GetComponent<FileSystem>().files.Count == 1)
        {
            open = true;
        }
        else
        {
            open = false;
        }

    }
    
    public override void Active()
    {
        GameObject player = GameObject.FindWithTag("Player");
        
        player.GetComponent<BaseAttack>().attackDamage += power;
        player.GetComponent<MovementTopDown>().moveSpeed += baseSpeed;   

    }
}
