using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    public Vector2 Direction;
    private Animator _animator;
    public Vector3 Velocity
    {
        get
        {
            return _velocity;
        }
    }
    public int moveDir;
    public float moveSpeed = 3.0f;
    public float maxYVelocity = 5;
    public uint jumpCount = 2;
    public float jumpVelocity1 = 8.5f;
    public float jumpVelocity2 = 7;
    float minJumpVelocity;
    bool onGround = true;
    NewCollider2D obstaclesController;
    Vector3 _velocity;

    void Start()
    {
        _animator = GetComponent<Animator>();
        obstaclesController = GetComponent<NewCollider2D>();
        minJumpVelocity = Mathf.Sqrt(2 * Mathf.Abs(-0.4f) * 7.8f);
    }

    void CalculateVelocity()
    {
        _velocity.x = moveDir * moveSpeed;
        _velocity.y += -0.4f;
        _velocity.y = Mathf.Max(_velocity.y, -maxYVelocity);
    }
    void FixedUpdate()
    {
        CalculateVelocity();
        obstaclesController.Move(_velocity);
        if (moveDir != 0)
        {
            _animator.SetBool("isMoving", true);
        }
        else
        {
            _animator.SetBool("isMoving", false);
        }
        if (obstaclesController.collisions.below && !onGround)
        {
            onGround = true;
        }
        else if (!obstaclesController.collisions.below && onGround)
        {
            onGround = false;
        }

        if (onGround)
        {
            _velocity.y = 0;
            jumpCount = jumpCount > 9999 ? jumpCount : 2;
        }
        else if (obstaclesController.collisions.above)
        {
            _velocity.y = -0.4f;
        }
      
    }
    public void SetMoveDir(int movedir)
    {
        moveDir = movedir;
        if(moveDir > 0)
        {
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
        if (moveDir < 0)
        {
            transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
    }
    public void OnJumpInputDown()
    {
        if (onGround || jumpCount > 0)
        {
            jumpCount--;
            if (jumpCount == 0 || !onGround)
            {
                SecondJump();
            }
            else if (jumpCount > 0 && onGround)
            {
                FirstJump();
            }

            onGround = false;
        }
    }

    void FirstJump()
    {
        _velocity.y = jumpVelocity1;
    }

    void SecondJump(bool giveBoost = false)
    {

        _velocity.y = jumpVelocity2 + 0.25f;


        if (!onGround)
        {
            jumpCount = jumpCount > 1 ? jumpCount : 0;
        }
    }

    public void OnJumpInputUp()
    {
        if (_velocity.y > minJumpVelocity)
        {
            _velocity.y = minJumpVelocity;
        }
    }
}
