using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    private SpriteRenderer _playerSprite;
    private Rigidbody2D _ridigbody;
    private float _jumpForce = 5f;
    private int _direction = 1;

    public float Speed { get; private set; } = 0;

    private void Start()
    {
        _playerSprite = GetComponent<SpriteRenderer>();
        _ridigbody = GetComponent<Rigidbody2D>();
    }

    public void MoveLeft()
    {
        SetDirection(-_direction);
    }

    public void MoveRight()
    {
        SetDirection(_direction);
    }

    public void Jump()
    {
        if (Mathf.Abs(_ridigbody.velocity.y) < 0.1f)
        {
            _ridigbody.AddForce(new Vector2(0, _jumpForce), ForceMode2D.Impulse);
        }
    }

    public void Stop()
    {
        Speed = 0;
    }

    private void SetDirection(int direction)
    {
        SmoothigSpeed();

        transform.position += new Vector3(direction, 0, 0) * Speed * Time.deltaTime;

        FlipCharacter(direction);
    }

    private void FlipCharacter(int direction)
    {
        if (direction < 0)
        {
            _playerSprite.flipX = true;
        }
        else if (direction > 0)
        {
            _playerSprite.flipX = false;
        }
    }

    private void SmoothigSpeed()
    {
        float maxSpeed = 2f;
        float timeSpeedUp = 1f;

        Speed = Mathf.Lerp(Speed, maxSpeed, Time.deltaTime * timeSpeedUp);
    }
}
