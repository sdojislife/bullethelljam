using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] private bool _attackFromStart;
    [SerializeField] private float _delay;
    [SerializeField] private LayerMask _rayLayer;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private DefaultCard _card;
    private bool _canAttack = true;
    private void Start()
    {
        if (_attackFromStart)
        {
            StartCoroutine(AttackWithDelay());
        }
    }
    private IEnumerator AttackWithDelay()
    {
        while (true)
        {
            _card.CastSpell();
            yield return new WaitForSeconds(_delay);
        }
    }
    private void Update()
    {
        if (!_attackFromStart)
        {
            if (Physics2D.Raycast(transform.position, _playerTransform.position - transform.position, Mathf.Infinity, _rayLayer).collider.TryGetComponent(out Player player) && _canAttack)
            {
                _card.CastSpell();
                StartCoroutine(CanAttackRoutine());
            }
        }
    }
    private IEnumerator CanAttackRoutine()
    {
        _canAttack = false;
        yield return new WaitForSeconds(_delay);
        _canAttack = true;
    }
}
