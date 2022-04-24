using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private Player _player;
    void Start()
    {
        _player = GetComponent<Player>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _player.Direction = Vector2.right;
            _player.SetMoveDir(1);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            _player.Direction = Vector2.left;
            _player.SetMoveDir(-1);
        }
        else
        {
            _player.SetMoveDir(0);
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            _player.OnJumpInputDown();
        }
        if (Input.GetKeyUp(KeyCode.Z))
        {
            _player.OnJumpInputUp();
        }
    }
}
