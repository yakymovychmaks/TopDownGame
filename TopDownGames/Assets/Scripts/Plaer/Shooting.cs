using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField]private Transform  _firepoint;
    [SerializeField] private GameObject _booletPrefab;

    // [SerializeField] private float _booletForce = 20f;

    [SerializeField] private float _attackRate = 1f;
    float nextAttackTime = 0f;

    [SerializeField] private Plaer _person;
    [SerializeField] private AudioSource _ShotsAudio;

    // bool shot = false;

        // void Update()
        // {
        //     // if(Input.GetButton("Fire1"))
        //     // shot = true;
        // }

    void Start()
    {
        switch(_person.selectPlaer)
        {
            case 0:
                _attackRate = 10f;
                //_booletForce = 15f;
                break;
            case 1:
                _attackRate = 5f;
                //_booletForce = 25f;
                break;
            case 2:
                _attackRate = 2f;
                // _booletForce = 25f;
                break;
        }
    }
    
    void Update()
    {
        // PlaerMovement plaerCont = new PlaerMovement();
        // if(plaerCont.CheckControlesType())
        // {
            if(Time.time >= nextAttackTime)
                if(Input.GetButton("Fire1"))
                {
                    Shoot();
                    nextAttackTime = Time.time + 1f / _attackRate;
                    _ShotsAudio.Play();
                }
        // }
        // else 
        // {

        // }

    }

    public void Shoot()
    {
        GameObject boolet = Instantiate(_booletPrefab, _firepoint.position, _firepoint.rotation);
        // Rigidbody2D rb = boolet.GetComponent<Rigidbody2D>();
        // rb.AddForce(_firepoint.right * _booletForce, ForceMode2D.Impulse);
    } 
}
