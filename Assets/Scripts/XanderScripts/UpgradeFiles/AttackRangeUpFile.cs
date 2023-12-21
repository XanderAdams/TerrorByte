using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New File", menuName = "UpgradeFile/Attack/Range/Times")]
public class AttackRangeUpFile : File
{
    
    public float range;

    public override void Passive()
    {
        //Debug.Log("Passive");
        if(GameObject.FindWithTag("Player").GetComponent<BaseAttack>()!=null)
        {
            GameObject.FindWithTag("Player").GetComponent<BaseAttack>().attackRange *= range;
        }
    
    }
}
