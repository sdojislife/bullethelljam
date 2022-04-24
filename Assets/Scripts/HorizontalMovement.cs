using UnityEngine;

public class HorizontalMovement : MovementSelector
{
    [SerializeField] private float _x1, _x2;
    private Movement _movement;
    private void Awake()
    {
        _movement = GetComponent<Movement>();
    }
    public override void SelectDirection()
    {
        if(transform.position.x < _x1)
        {
            _movement.Direction = Vector2.right;
        }
        if (transform.position.x > _x2)
        {
            _movement.Direction = Vector2.left;
        }
    }
}
