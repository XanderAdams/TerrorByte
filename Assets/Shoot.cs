using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject Bullet;
    public float bulletSpeed = 10f;
    public Transform target;
    bool Detect = false;
    Vector2 Direction;
    public float Range;
    public float FireRate;
    float nextTimeToFire = 0;

    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 targetpos = target.position;
        Direction = targetpos - (Vector2)transform.position;

        RaycastHit2D rayInfo = Physics2D.Raycast(transform.position, Direction, Range);
        Debug.DrawRay(transform.position, Direction);

        Debug.Log("Hit" + rayInfo.collider.gameObject.name);
        if (rayInfo)
        {
            if (rayInfo.collider.CompareTag("Player"))
            {


                Detect = true;

            }

            else
            {


                Detect = false;

            }
        }

        if (Detect)
        {
            FirePoint.transform.forward = Direction;
            if (Time.deltaTime > nextTimeToFire)
            {
                nextTimeToFire = Time.deltaTime + 1 / FireRate;
                shoot();
                Debug.Log("shoot");
            }
        }
    }


    /* private void OnTriggerEnter2D(Collider2D other)
     {
         if(other.tag == "player")
         {
             RaycastHit2D rayInfo = Physics2D.Raycast(transform.position, Direction, Range);
             if (rayInfo)
             {
                 if(rayInfo.collider.gameObject.tag == "Player")
                 {
                     if(Detect == false)
                     {
                         Detect = true;
                     }
                 }

                 else
                 {
                     if(Detect == true)
                     {
                         Detect = false;
                     }
                 }
             }
         }
     }*/

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
