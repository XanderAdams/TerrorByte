using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float bulletTime = 3;
    

    // Update is called once per frame
    void Update()
    {
        bulletTime -= Time.deltaTime;
        if (bulletTime <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == ("Player"))
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == ("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
