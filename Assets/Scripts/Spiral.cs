using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spiral : AttackPattern
{
    [SerializeField] private float _angleStep;
    [SerializeField] private float _angleStart, _angleEnd;
    private float _angle = 0;
    protected override void Play()
    {
            Movement projectile = Instantiate(_projectile, _spawnPosition.position, Quaternion.identity);
            projectile.Direction = new Vector2(Mathf.Cos(_angle * Mathf.PI / 180), Mathf.Sin(_angle * Mathf.PI / 180));
            _angle += _angleStep;
            if (_angle > _angleEnd)
            {
                _angle = _angleStart;
            }
            if (_angle < _angleStart)
            {
                _angle = _angleEnd;
            }
            _onPlayed.Invoke();
    }
}