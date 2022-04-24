using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Vector2 _direction;
    [SerializeField] protected float _speed;
    public Vector2 Direction
    {
        get => _direction;
        set
        {
            _direction = value;
        }
    }
    protected virtual void Update()
    {
        transform.Translate(_speed * _direction * Time.deltaTime);
    }
}
