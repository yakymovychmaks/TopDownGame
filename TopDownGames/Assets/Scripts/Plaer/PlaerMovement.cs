using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaerMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private Camera _cam;
    [SerializeField] private Plaer _person;
    Vector2 movement;
    Vector2 mousePos;

    void Start()
    {
        // Plaer plaer = GetComponent<Plaer>
        switch(_person.selectPlaer)
        {
            case 0:
                _speed = 10f;
                break;
            case 1:
                _speed = 1f;
                break;
            case 2:
                _speed = 15f;
                break;
        }
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = _cam.ScreenToWorldPoint(Input.mousePosition);
    }

    void FixedUpdate()
    {
        _rb.MovePosition(_rb.position + movement * _speed * Time.fixedDeltaTime);

        Vector2 lookDir = mousePos - _rb.position;

        float angele = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        _rb.rotation = angele;
    }
}
