using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class WeaponParent : MonoBehaviour
{
   public Animator animator;
   public float delay = 0.3f;
   private bool attackBlocked;
   public Vector2 PointerPosition { get; set; }
   public bool IsAttacking { get; private set; }
   public Transform circleOrigin;
   public float radius;
   public int attackDamage = 5;
   public LayerMask enemyLayers;

    public void ResetIsAttacking()
    {
        IsAttacking = false;
    }

    private void Update()
   {
        if (IsAttacking)
            return;
        transform.right = (PointerPosition - (Vector2)transform.position).normalized;
        if (Input.GetMouseButton(0))
        {
            Attack();
        }
    }

    





   void Attack()
   {
       if (attackBlocked)
           return;
       animator.SetTrigger("Attack");
       Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(circleOrigin.position, radius, enemyLayers);
       foreach (Collider2D enemy in hitEnemies)
        {
            
           enemy.gameObject.GetComponent<Enemy>().TakeDamage(attackDamage);
        }
       IsAttacking = true;
       attackBlocked = true;
       StartCoroutine(DelayAttack());

       
   }

   private IEnumerator DelayAttack()
   {
        yield return new WaitForSeconds(delay);
        attackBlocked = false;
   }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Vector3 position = circleOrigin.position == null ? Vector3.zero : circleOrigin.position;
        Gizmos.DrawWireSphere(position, radius);
    }

   
}
