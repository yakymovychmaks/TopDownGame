using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    // [SerializeField] private GameObject _hitEffect;
    void Start()
    {
        Destroy(gameObject, 1f);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        // GameObject effect =  Instantiate(_hitEffect, transform.position, Quaternion.identity);
        // Destroy(effect, 5f);
        Destroy(gameObject);
    }
    
}
