using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : Projectile
{


    private void Update()
    {
        MoveProjetctileEnemy();
    }


    protected override void MoveProjetctileEnemy()
    {
        base.MoveProjetctileEnemy();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            IDamageable damageable = other.GetComponent<IDamageable>();
            damageable.TakeDamage(_damage);
            Debug.Log("hit");
            Destroy(gameObject);
        }

    }

}
