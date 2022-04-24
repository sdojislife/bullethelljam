using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2 : Movement
{
    protected override void Update()
    {
        if(Direction != Vector2.zero)
        {
            transform.position = Vector2.MoveTowards(transform.position, Direction * int.MaxValue, _speed * Time.deltaTime);
        }
    }
}
