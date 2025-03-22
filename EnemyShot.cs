using System.Collections;
using UnityEngine;

public class EnemyShot : MonoBehaviour
{
    [SerializeField] private LayerMask _playerLayerMask;
    [SerializeField] private GameObject _projectileEnemyPrefab;
    [SerializeField] private float shootDelay = 4f; 

    private bool isShooting = false; 

    private void Update()
    {
        CheckRaycast();
    }

    private void CheckRaycast()
    {
        Vector2 origin = transform.position;
        Vector2 direction = Vector2.down;
        float distance = 30f;

        RaycastHit2D hit = Physics2D.Raycast(origin, direction, distance, _playerLayerMask);
        Debug.DrawRay(origin, direction * distance, Color.red);

        if (hit.collider != null && !isShooting) 
        {
            Debug.Log("Луч попал в объект: " + hit.collider.name);
            StartCoroutine(CreateEnemyProjectile());
        }
    }

    IEnumerator CreateEnemyProjectile()
    {
        isShooting = true;
        Instantiate(_projectileEnemyPrefab, transform.position, Quaternion.identity); 
        yield return new WaitForSeconds(shootDelay); 
        isShooting = false; 
    }
}