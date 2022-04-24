using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionRandomizer : MonoBehaviour
{
    [SerializeField] private float _x1, _x2, _y1, _y2;
    public void SetRandomPosition() => transform.position = new Vector2(Random.Range(_x1, _x2), Random.Range(_y1, _y2));
}