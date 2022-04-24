using System.Collections;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private AudioSource _audio;
    [SerializeField] private Movement _projectile;
    [SerializeField] private Player _player;
    [SerializeField] private float _delay;
    private bool _canAttack = true;
    private void Update()
    {
        if(Input.GetKey(KeyCode.X) && _canAttack)
        {
            Movement projectile = Instantiate(_projectile, transform.position, Quaternion.identity);
            projectile.Direction = _player.Direction;
            StartCoroutine(CanAttackRoutine());
        }
        if (Input.GetKey(KeyCode.C) && _canAttack)
        {
            Movement projectile = Instantiate(_projectile, transform.position, Quaternion.identity);
            projectile.Direction = Vector2.up;
            StartCoroutine(CanAttackRoutine());
        }
    }
    private IEnumerator CanAttackRoutine()
    {
        _audio.Play();
        _canAttack = false;
        yield return new WaitForSeconds(_delay);
        _canAttack = true;
    }
}
