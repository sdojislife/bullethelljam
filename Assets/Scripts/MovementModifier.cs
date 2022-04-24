using UnityEngine;
using System.Collections;
public abstract class MovementModifier : MonoBehaviour
{ 
    [SerializeField] private float _initializeTiming;
    protected Movement _movement;
    private void Start()
    {
        _movement = GetComponent<Movement>();
        StartCoroutine(RunInitialize());
    }
    private IEnumerator RunInitialize()
    {
        yield return new WaitForSeconds(_initializeTiming);
        Initialize();
    }
    public abstract void Initialize();
}
