using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    [SerializeField] private PlaerMovement _plaer;
    [SerializeField] private Rigidbody2D _rb;
    // [SerializeField] private Transform _transform;
    [SerializeField] private LayerMask _whatIsSolid;
    [SerializeField] private float _radiusRaucast = 0.5f;
    [SerializeField] private float _distance = 1f;
    [SerializeField] private int _damage;
    public int Damage => _damage;
    [SerializeField] private float _spead;
    [SerializeField] private int _health = 20;
    public int Health => _health;
    [SerializeField] private GameObject _partSistem;
    Vector2 movement;
    
    public void SetHealth(int newValue) => _health = newValue;
    
    // public void SetsDifficults(int setsdiff)
    // {
    //     if(setsdiff == 0){}
    //     else
    //     {
    //         PlayerPrefs.SetInt("SetDamage", 5);
    //         PlayerPrefs.SetFloat("SetSpead", 2f);
    //     }
    // }

    void Start()
    {

        _plaer = FindObjectOfType<PlaerMovement>();
        Destroy(gameObject, 30f);
        
    }

    void Update()
    {
        RaycastHit2D hitInfo = Physics2D.CircleCast(transform.position, _radiusRaucast, transform.up, _distance, _whatIsSolid);
        movement = _plaer.positions - _rb.position;
        if(hitInfo.collider != null)
        {
            if(hitInfo.collider.CompareTag("Plaer"))
            {
                Instantiate(_partSistem, transform.position, Quaternion.identity);
                Debug.Log("plaer");
                Plaer plaer = hitInfo.collider.GetComponent<Plaer>();
                plaer.SetHealth(plaer.Health - Damage);
                Destroy(gameObject);
            }
        }
        
        float angele = Mathf.Atan2(movement.y, movement.x) * Mathf.Rad2Deg -90f;
        _rb.rotation = angele;
        transform.Translate(Vector2.up * _spead * Time.deltaTime);
        if(_health<=0)
        Destroy(gameObject);
    }
}
