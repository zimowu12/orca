using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Photon.Pun;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    private Rigidbody2D _rigidbody;

    private Vector2 _movementInput;

    PhotonView view;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        view = GetComponent<PhotonView>();
    }

    private void FixedUpdate()
    {
        if(view.IsMine)
        {
            //rb.MovePosition(rb.position + movement.normalized * moveSpeed * Time.fixedDeltaTime);
            _rigidbody.velocity = _movementInput * _speed;  
        }
        
    }

    private void OnMove(InputValue inputValue)
    {
        _movementInput = inputValue.Get<Vector2>();
    }
}
