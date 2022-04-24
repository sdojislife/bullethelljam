using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
    public abstract class AttackPattern : MonoBehaviour
    {
        [SerializeField] private AudioSource _shootSound;
        [SerializeField] private float _startDelay;
        [SerializeField] private float _iterationsDelay;
        [SerializeField] private int _iterations;
        [SerializeField] protected Transform _spawnPosition;
        [SerializeField] protected Movement _projectile;
        [SerializeField] protected UnityEvent _onPlayed;
        public IEnumerator Act()
        {
            yield return new WaitForSeconds(_startDelay);
            for (int i = 0; i < _iterations; i++)
            {
                Play();
                _shootSound.Play();
                yield return new WaitForSeconds(_iterationsDelay);
            }
            StopAllCoroutines();
        }
        protected abstract void Play();
    }