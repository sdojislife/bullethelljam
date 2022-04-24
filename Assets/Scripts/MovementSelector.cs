using UnityEngine;

public abstract class MovementSelector : MonoBehaviour
{
    public abstract void SelectDirection();
    private void Update()
    {
        SelectDirection();
    }
}
