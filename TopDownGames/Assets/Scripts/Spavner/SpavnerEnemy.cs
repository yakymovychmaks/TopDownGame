using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpavnerEnemy : MonoBehaviour
{
    [SerializeField] private Transform _spavnPoint;
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private float _spavnRate = 1f;
    public float _spavner;
    [SerializeField] private int _setDifcalt = 50;
    public int _dificalt;
    float nextSpavnTime = 0f;
    private void Start()
    {
        _spavner = _spavnRate;
        _dificalt = _setDifcalt;
    }
    void Update()
    {
        if(Time.time >= nextSpavnTime)
        {
            SpavnEnemy();
            nextSpavnTime = Time.time +10f / _spavner;
            
        }
        if(nextSpavnTime > _dificalt)
        {
            _spavner+=1;
            _dificalt+=50;
        }
    }

    void SpavnEnemy()
    {
        GameObject enemy = Instantiate(_enemyPrefab, _spavnPoint.position,_spavnPoint.rotation);
    }

}
