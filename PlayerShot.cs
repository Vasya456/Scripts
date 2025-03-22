using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour
{
    [SerializeField] private GameObject _projectilePrefab;


    private void Update()
    {
        Shot();
    }

    private void Shot() 
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(_projectilePrefab, transform.position, Quaternion.identity);
        }
    }

}
