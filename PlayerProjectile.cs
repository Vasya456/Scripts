using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilePlayer : Projectile 
{
   


    private void Update()
    {
        MoveProjectilePlayer();
    }


    protected override void MoveProjectilePlayer()
    {
        base.MoveProjectilePlayer();
    }



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            IDamageable damageable = other.GetComponent<IDamageable>();
            damageable.TakeDamage(_damage);
            Debug.Log("hit");
            Destroy(gameObject);
        }
        
    }

}
   
    


   


