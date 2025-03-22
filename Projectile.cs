using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float _speedrojectile;
    [SerializeField] protected int _damage = 10;

  
    protected virtual void MoveProjectilePlayer()
    {
        transform.Translate(Vector3.up * _speedrojectile * Time.deltaTime);
    }

    protected virtual void MoveProjetctileEnemy()
    {
        transform.Translate(Vector3.down * _speedrojectile * Time.deltaTime);
    }

    

}
   
    


   


