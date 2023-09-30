using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class BaseAttack : MonoBehaviour
{


    // Update is called once per frame


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }


        void Attack()
        {
            Debug.Log("Kill It White Boy");
        }
    }
}
