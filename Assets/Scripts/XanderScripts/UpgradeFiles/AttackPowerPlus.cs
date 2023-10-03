using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New File", menuName = "UpgradeFile/Attack/Power/Plus")]
public class AttackPowerPlus : File
{

    public int power;

    public override void Passive()
    {
        Debug.Log("Passive");
        if (GameObject.FindWithTag("Player").GetComponent<BaseAttack>() != null)
        {
            GameObject.FindWithTag("Player").GetComponent<BaseAttack>().attackDamage += power;
        }

    }
}
