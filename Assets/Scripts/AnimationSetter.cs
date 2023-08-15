using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent (typeof(PlayerMovement))]
public class AnimationSetter : MonoBehaviour
{
    private const string AnimationSpeed = "Speed";

    private Animator _animator;
    private PlayerMovement _playerMover;

    void Start()
    {
        _animator = GetComponent<Animator>();
        _playerMover = GetComponent<PlayerMovement>();
    }

    void Update()
    {
        _animator.SetFloat(AnimationSpeed, Mathf.Abs(_playerMover.Speed));
    }
}
