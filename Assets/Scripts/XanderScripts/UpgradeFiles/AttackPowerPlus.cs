using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New File", menuName = "UpgradeFile/Attack/Power/Plus")]
public class AttackPowerPlus : File
{

    public int power;

    public override void Passive()
    {
        //Debug.Log("Passive");
        if (GameObject.FindWithTag("Player").GetComponent<WeaponParent>() != null)
        {
            GameObject.FindWithTag("Player").GetComponent<WeaponParent>().attackDamage += power;
        }

    }
}
