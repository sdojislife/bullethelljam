using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationType90 : RotationType
{
    public override void RotateToSight(Vector2 Direction)
    {
        if(Direction.x > 0)
        {
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
        if(Direction.x < 0)
        {
            transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
    }
}
