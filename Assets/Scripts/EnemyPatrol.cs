using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    [SerializeField] private Transform[] _targetPoints;

    private float _speed = 2f;
    private int _currentPoint = 0;

    private void FixedUpdate()
    {
        Transform target = _targetPoints[_currentPoint];

        transform.position = Vector2.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);

        if(Vector2.Distance(transform.position, target.position) < 0.2f)
        {
            _currentPoint++;

            if(_currentPoint >= _targetPoints.Length)
            {
                _currentPoint = 0;
            }
        }
    }
}
