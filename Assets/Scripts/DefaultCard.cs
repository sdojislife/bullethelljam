using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultCard : Spellcard
{
    public override void CastSpell()
    {
       foreach(AttackPattern pattern in _patterns)
        {
            pattern.StartCoroutine(pattern.Act());
        }
    }
}