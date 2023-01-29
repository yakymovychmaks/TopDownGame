using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : MonoBehaviour
{

    [SerializeField] private int _damage = 20;
    public int Damage => _damage;
    [SerializeField] private float _speed = 10f;

    [SerializeField] private float _distance = 0.1f;
    [SerializeField] private LayerMask _whatIsSolid;
    [SerializeField] private float _radiusRaucast = 0.1f;
    // [SerializeField] private ParticleSystem _explosionEffects;

    [SerializeField] private GameObject _partSistem;
    [SerializeField] private Plaer _plaer;

    // [SerializeField] private GameObject _hitEffect;
    void Start()
    {
        _plaer = FindObjectOfType<Plaer>();
        Destroy(gameObject, 10f);
    }

    void Update()
    {
        RaycastHit2D hitInfo = Physics2D.CircleCast(transform.position, _radiusRaucast, transform.up, _distance, _whatIsSolid);
        if(hitInfo.collider != null)
        {
            Instantiate(_partSistem, transform.position, Quaternion.identity);
            if(hitInfo.collider.CompareTag("Enemy"))
            {
                
                StatEnemy enemy = hitInfo.collider.GetComponent<StatEnemy>();
                enemy.SetHealth(enemy.Health - Damage);
                _plaer.SetScore();
            }
            if(hitInfo.collider.CompareTag("EnemyRanner"))
            {
                Enemy enemy1 = hitInfo.collider.GetComponent<Enemy>(); 
                enemy1.SetHealth(enemy1.Health - Damage);
                _plaer.SetScore();
            }
            
            Destroy(gameObject);
        }
        transform.Translate(Vector2.up * _speed * Time.deltaTime);
        
    }
    

    // void OnCollisionEnter2D(Collision2D collision)
    // {
    //     // GameObject effect =  Instantiate(_hitEffect, transform.position, Quaternion.identity);
    //     // Destroy(effect, 5f);
        
    //     if(collision.gameObject.CompareTag("Enemy"))
    //     {
    //         StatEnemy enemy = collision.gameObject.GetComponent<StatEnemy>();
    //         enemy.SetHealth(enemy.Health - Damage);
    //     }
    //     Destroy(gameObject);
        
        
    // }
    
}
