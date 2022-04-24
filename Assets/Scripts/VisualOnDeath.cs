using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualOnDeath : MonoBehaviour
{
    [SerializeField] private ParticleSystem _visualOnDeath;
    private void OnDestroy()
    {
        Instantiate(_visualOnDeath, transform.position, Quaternion.identity);
    }
}
