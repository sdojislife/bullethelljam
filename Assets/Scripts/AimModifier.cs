using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimModifier : MovementModifier
{
    [SerializeField] private Vector2 _aimPosition;
    public override void Initialize()
    {
        if (_aimPosition == Vector2.zero)
        {
            _movement.Direction = (GlobalData.Player.transform.position - transform.position).normalized;
        }
        else
        { 
            _movement.Direction = (_aimPosition - (Vector2)transform.position).normalized;
        }
        Destroy(this);
    }
}
