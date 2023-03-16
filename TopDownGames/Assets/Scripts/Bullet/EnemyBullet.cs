using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
   [SerializeField] private int _damage = 20;
    public int Damage => _damage;
    [SerializeField] private float _speed = 10f;

    [SerializeField] private float _distance = 10f;
    [SerializeField] private LayerMask _whatIsSolid;
    [SerializeField] private float _radiusRaucast = 10f;
    [SerializeField] private float _destroyTime = 1f;
    [SerializeField] private GameObject _partSistem;
    
    void Start()
    {
         Destroy(gameObject, _destroyTime);

    }

    
    void Update()
    {
        RaycastHit2D hitInfo = Physics2D.CircleCast(transform.position, _radiusRaucast, transform.up, _distance, _whatIsSolid);
        if(hitInfo.collider != null)
        {
            
            if(hitInfo.collider.CompareTag("Plaer"))
            {
                Instantiate(_partSistem, transform.position, Quaternion.identity);
                Plaer plaer = hitInfo.collider.GetComponent<Plaer>();
                plaer.SetHealth(plaer.Health - Damage);
                Destroy(gameObject);
            }
            
            
        }
        transform.Translate(Vector2.up * _speed * Time.deltaTime);
        
    }
}
