using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaerMovement : MonoBehaviour
{

    [Header("controls")]
    [SerializeField] private ControlType _controlType;
    public ControlType ControlTypes => _controlType;  
    [SerializeField] private Joystick _joystickMover;
    

    public enum ControlType{PC, Android}
    [Header("movements")]
    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody2D _rb;
    public Vector2 positions => _rb.position; 
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
                _speed = 5f;
                break;
            case 1:
                _speed = 1f;
                break;
            case 2:
                _speed = 15f;
                break;
        }
        if(_controlType == ControlType.PC)
        {
            _joystickMover.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        if(_controlType == ControlType.PC)
        {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = _cam.ScreenToWorldPoint(Input.mousePosition);
        }
        else if(_controlType == ControlType.Android)
        {
            movement.x = _joystickMover.Horizontal;
            movement.y = _joystickMover.Vertical;
        }
    }

    void FixedUpdate()
    {
        _rb.MovePosition(_rb.position + movement * _speed * Time.fixedDeltaTime);
        // if(_controlType == ControlType.PC)
        // {
        Vector2 lookDir = mousePos - _rb.position;

        float angele = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        _rb.rotation = angele;
        
        
    }
        
}
