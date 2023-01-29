using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatEnemy : MonoBehaviour
{
    [SerializeField] private int _health = 100;

    public int Health => _health;

    public void SetHealth(int newValue) => _health = newValue;

    void Update()
    {
        if(_health<=0)
        Destroy(gameObject);
    }

    // void OnCollisionEnter2D(Collision2D col)
    // {
    //     if(col.gameObject.CompareTag("Plaer"))
    //         Debug.Log("Plaer");
        
    // }
}
