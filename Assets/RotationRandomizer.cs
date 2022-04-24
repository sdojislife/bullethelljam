using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationRandomizer : MonoBehaviour
{
    [SerializeField] private float _x1, _x2;
    private void Update()
    {
        transform.Rotate(0, 0, Random.Range(_x1, _x2));
    }
}
