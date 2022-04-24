using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    private void Update()
    {
        transform.Rotate(0, 0, _rotationSpeed * Time.deltaTime * transform.localScale.x);
    }
}
