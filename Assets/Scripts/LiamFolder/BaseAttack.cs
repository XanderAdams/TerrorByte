using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.InputSystem;

public class BaseAttack : MonoBehaviour
{
   
    public Animator animator;

    public Transform attackPoint;

    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    // Update is called once per frame
    public int attackDamage = 5;
    private WeaponParent weaponParent;

    [SerializeField]
    public InputActionReference pointerPosition;

    private void Awake()
    {
        //weaponParent = GetComponentInChildren<WeaponParent>();
    }

    void Update()
    {

        //pointerInput = GetPointerInput();
       // weaponParent.PointerPosition = pointerInput();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
          
        }


        
    }

    void Attack()
    {
        animator.SetTrigger("Attack");

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        foreach(Collider2D enemy in hitEnemies)
        {
            //Debug.Log("Enemy: " + enemy.gameObject.name);
            enemy.gameObject.GetComponent<Enemy>().TakeDamage(attackDamage);
        }
    }
    private Vector2 GetPointerInput()
    {
        Vector3 mousePos = pointerPosition.action.ReadValue<Vector2>();
        mousePos.z = Camera.main.nearClipPlane;
        return Camera.main.ScreenToWorldPoint(mousePos);
    }

    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
