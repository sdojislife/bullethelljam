using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationType360 : RotationType
{
    public override void RotateToSight(Vector2 Direction)
    {
        Vector2 difference = Direction * int.MaxValue - (Vector2)transform.position;
        float angle = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }
}
