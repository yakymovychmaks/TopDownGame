using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plaer : MonoBehaviour
{
    [SerializeField] Bullet hits;
    [SerializeField] private int _whichPlaer = 0;

    public int selectPlaer => _whichPlaer;

    [SerializeField] private float Health;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Bullet"))
        Destroy(gameObject);
    }
    // void Update()
    // {

    // }
}
