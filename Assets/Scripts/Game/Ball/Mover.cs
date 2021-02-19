using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;

    private Rigidbody2D _rigidbody2D;
    private bool _onGround;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _rigidbody2D.AddForce(Vector2.right * _speed);
        TryJump();
    }

    private void TryJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _onGround)
            _rigidbody2D.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        _onGround = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        _onGround = false;
    }
}
