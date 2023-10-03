using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public TheKillsYouScript virus;
    public int power = 1;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            for (int i = 0; i < power; i++)
            {
                virus.Scan();
            }
            Debug.Log("Hit");
        }

        
        
    }
    public void update()
    {

        virus = GameManager.Instance.gameObject.GetComponent<TheKillsYouScript>();
    }
}
