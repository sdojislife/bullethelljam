using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suicide : MonoBehaviour
{
    [SerializeField] private float _delay;
    void Start()
    {
        if (_delay != 0)
        {
            Destroy(gameObject, _delay);
        }
        else
        {
            Destroy(gameObject, 1f);
        }
    }
}
