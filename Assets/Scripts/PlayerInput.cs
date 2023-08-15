using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
public class PlayerInput : MonoBehaviour
{
    private PlayerMovement _mover;

    private void Start()
    {
        _mover = GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            _mover.MoveLeft();
        }

        if (Input.GetKey(KeyCode.D))
        {
            _mover.MoveRight();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _mover.Jump();
        }

        if (Input.anyKey == false)
        {
            _mover.Stop();
        }
    }
}
