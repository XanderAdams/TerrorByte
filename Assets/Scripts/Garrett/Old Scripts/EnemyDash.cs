using Pathfinding;
using UnityEngine;


public class EnemyDash : MonoBehaviour
{
    public AIPath ai;
    public AIDestinationSetter setter;

    public Transform target;
    Vector2 Direction;
    float range = 10f;
    private Rigidbody2D rb;

    public Transform launchPoint;
    public GameObject summon;
    public float launchSpeed = 10f;
    public float Range;
    public float summonRate = 1f;
    float nextSummon;
    private float currentLoop = 0;
    private float maxLoop = 1;

    bool canDash = true;


    public float dashTime = 0f;
    public float dashTimeMax = 5f;
    public float dashCooldown = 0f;
    public float maxCooldown = 10f;
    public float insight = 0f;
    public float insightMax = 1f;
    public float charge = 0f;
    public float chargeMax = 2f;


    public LayerMask layer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 targetpos = target.position;
        Direction = targetpos - (Vector2)transform.position;

        RaycastHit2D rayInfo = Physics2D.Raycast(transform.position, Direction, 100, layer);
        Debug.DrawRay(transform.position, Direction);

        if (dashCooldown <= maxCooldown)
        {
            dashCooldown += Time.deltaTime;

        }
        if (dashCooldown >= maxCooldown)
        {
            canDash = true;
        }

        if (rayInfo)
        {
            if (rayInfo.collider.CompareTag("Player"))
            {
                if (insight <= insightMax)
                {
                    insight += Time.deltaTime;
                }



            }
        }
        if (insight >= insightMax && canDash == true)
        {
            Debug.Log("Dash");
            Dash();

            

        }

        
        
    }

    
    void shoot()
    {
        GameObject BulletIns = Instantiate(summon, launchPoint.position, Quaternion.identity);
        BulletIns.SetActive(true);
        BulletIns.GetComponent<Rigidbody2D>().AddForce(Direction * launchSpeed);
    }

    void Dash()
    {
        Debug.Log("Dash Startr");

        ai.maxSpeed = 0;
        gameObject.GetComponent<AIDestinationSetter>().enabled = false;
        if (charge <= chargeMax)
        {
            Debug.Log("Charged");
            charge += Time.deltaTime;
        }

        if (charge >= chargeMax) //IFinished charging
        {
            Debug.Log("speedup");

            ai.maxSpeed = 25;

            Debug.Log("Test");
            Debug.Log(ai.maxSpeed);



            if (dashTime <= dashTimeMax)
            {
                Debug.Log("Countin");
                dashTime += Time.deltaTime;
                Debug.Log(dashTime);

                if (dashTime >= dashTimeMax)
                {
                    ai.maxSpeed = 2;

                    dashCooldown = 0f;
                    insight = 0f;
                    canDash = false;
                    charge = 0f;
                    dashTime = 0f;

                    if (currentLoop <= maxLoop)
                    {
                        Debug.Log("summon");
                        shoot();
                        currentLoop += 1;
                    }
                    currentLoop = 0;

                }
            }

            Debug.Log("Finished");

            gameObject.GetComponent<AIDestinationSetter>().enabled = true;

            


        }


    }
}
