using UnityEngine;
using System.Collections;
public class Circle : AttackPattern
{
    [SerializeField] private int _bulletCount;
    [SerializeField] private float _angleStep;
    protected override void Play()
    {
            float angle = 0;
            for (int i = 0; i < _bulletCount; i++)
            {
                Movement projectile = Instantiate(_projectile, _spawnPosition.position,transform.rotation);
                projectile.Direction = new Vector2(Mathf.Cos(angle * Mathf.PI / 180), Mathf.Sin(angle * Mathf.PI / 180));
                angle += _angleStep;
            }
            _onPlayed.Invoke();
    }
}
