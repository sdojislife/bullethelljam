using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnchildModifier : MovementModifier
{
    public override void Initialize()
    {
        transform.parent = null;
    }
}
