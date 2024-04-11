using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public static PlayerMovment instance;  

    private Rigidbody2D _mainRigidbody;

    protected float horisontal;
    protected float vertical;

    [SerializeField] private float _walkSpeed;
    [SerializeField] private float _runSpeed;

    private void Awake()
    {
        _mainRigidbody = GetComponent<Rigidbody2D>();

        if(instance == null)
            instance = this;
    }
    private void Update()
    {
        horisontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.LeftShift)) //поменять на inputAxis
            _mainRigidbody.velocity = new Vector2(horisontal* _runSpeed, vertical* _runSpeed);
        else
            _mainRigidbody.velocity = new Vector2(horisontal * _walkSpeed, vertical * _walkSpeed);
    }
}
