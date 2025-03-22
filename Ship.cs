using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour , IDamageable
{
  

    [SerializeField] protected float _speed;
    [SerializeField] protected float _health;
    [SerializeField] protected const float  _xRange = 30;

   protected float _horInput;
    
    protected virtual void PlayerMoveShip()
    {
        transform.Translate(Vector3.right * _horInput * _speed * Time.deltaTime);
        _horInput = Input.GetAxis("Horizontal");

    }

    protected virtual void RangePosition()
    {
        if (transform.position.x < -_xRange)
        {
            transform.position = new Vector3(-_xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > _xRange)
        {
            transform.position = new Vector3(_xRange, transform.position.y, transform.position.z);
        }
    }


    public void TakeDamage(float damage)
    {
        _health -= damage;
        if (_health <= 0)
        {
            Destroy(gameObject);
            Debug.Log("player is dead");
        }
    }
}
