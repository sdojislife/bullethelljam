using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionModifier : MovementModifier
{
    [SerializeField] float _x1, _x2, _y1, _y2;
    public override void Initialize()
    {
        float x = Random.Range(_x1, _x2);
        float y = Random.Range(_y1, _y2);
        _movement.Direction = new Vector2(x,y);
        Destroy(this);
    }
}
