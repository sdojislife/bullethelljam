using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private int _maxHealth;
    private void Awake()
    {
        _health = _maxHealth;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 9)
        {
            _health--;
            if(_health < 1)
            {
                Destroy(gameObject);
            }

        }
    }
}
