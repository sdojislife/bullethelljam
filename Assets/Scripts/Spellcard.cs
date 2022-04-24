using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class Spellcard : MonoBehaviour
{
    public AttackPattern[] _patterns;
    [SerializeField] protected UnityEvent _onPlayed;
    public abstract void CastSpell();
}
