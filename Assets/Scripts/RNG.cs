using UnityEngine;
using System.Collections;
public class RNG : AttackPattern
{
    protected override void Play()
    {
            int angle = Random.Range(0, 360);
            Movement projectile = Instantiate(_projectile, _spawnPosition.position, Quaternion.identity);
            projectile.Direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
            _onPlayed.Invoke();        
    }
}
