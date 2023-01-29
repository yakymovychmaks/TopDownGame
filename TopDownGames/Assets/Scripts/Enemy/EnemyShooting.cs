using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    [SerializeField] private Transform _firepoint;
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private float _attackRate = 1f;
    float nextAttackTime = 0f;
    [SerializeField] private PlaerMovement _plaerPos;
    [SerializeField] private Rigidbody2D _rb;
    Vector2 plaerPos;
    
    void Update()
    {
        plaerPos = _plaerPos.positions - _rb.position;
        if(Time.time >= nextAttackTime)
        {
            Shoot();
            nextAttackTime = Time.time + 1f/ _attackRate;
        }
    }
    public void Shoot()
    {
        float angele = Mathf.Atan2(plaerPos.y, plaerPos.x) * Mathf.Rad2Deg - 90f;
        // Vector2 angele = plaerPos;
        _rb.rotation = angele;
        GameObject bullet = Instantiate(_bulletPrefab, _firepoint.position, _firepoint.rotation);
    }
}
