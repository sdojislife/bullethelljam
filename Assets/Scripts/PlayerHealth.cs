using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    public static int CurrentHits;
    [SerializeField] private AudioSource _deathSound;
    [SerializeField] private SpriteRenderer _renderer;
    private bool _canTakeDamage = true;
    private void Awake()
    {
        _renderer = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 8 && _canTakeDamage)
        {
            CurrentHits++;
            _deathSound.Play();
            StartCoroutine(TakeDamageRoutine());
          
        }
    }
    private IEnumerator TakeDamageRoutine()
    {
        _canTakeDamage = false;
        _renderer.color = new Color(1,1,1,0.5f);
        yield return new WaitForSeconds(0.5f);
        _renderer.color = new Color(1, 1, 1, 1);
        _canTakeDamage = true;
    }
}
