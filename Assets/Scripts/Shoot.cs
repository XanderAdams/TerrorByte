using UnityEngine;
using Pathfinding;

public class Shoot : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject Bullet;
    public float bulletSpeed = 10f;
    public Transform target;
    Vector2 Direction;
    public float Range;
    public float fireRate = 1f;
    float nextFire;
    public AIPath aiPath;
    public LayerMask layer;

    public float switchDelay = .5f;
    float timer;

    // Update is called once per frame
    void Update()
    {
        
        Vector2 targetpos = target.position;
        Direction = targetpos - (Vector2)transform.position;

        RaycastHit2D rayInfo = Physics2D.Raycast(transform.position, Direction, Range, layer);
        Debug.DrawRay(transform.position, Direction);

        Debug.Log("Hit" + rayInfo.collider.gameObject.name);
        if (rayInfo)
        {
            if (rayInfo.collider.CompareTag("Player"))
            {
                timer += Time.deltaTime;
                if (timer > switchDelay)
                {
                    aiPath.endReachedDistance = 9f;

                }
                if (Time.time > nextFire)
                {
                    nextFire = Time.time + fireRate;
                    shoot();
                    Debug.Log("shoot");
                }
            }
            else
            {
                aiPath.endReachedDistance = 1f;
            }


        }
    }


    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, Range);
    }

    void shoot()
    {
        GameObject BulletIns = Instantiate(Bullet, FirePoint.position, Quaternion.identity);
        BulletIns.GetComponent<Rigidbody2D>().AddForce(Direction * bulletSpeed);
    }

   

}
