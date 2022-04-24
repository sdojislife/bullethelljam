using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurvingModifier : MovementModifier
{
    [SerializeField] float _x1, _x2,_y1,_y2;
    private Vector2 _curving;
    public override void Initialize()
    {
        _curving = new Vector2(Random.Range(_x1, _x2), Random.Range(_y1, _y2));
    }
    private void FixedUpdate()
    {
        _movement.Direction += _curving * Time.deltaTime;
    }
}
