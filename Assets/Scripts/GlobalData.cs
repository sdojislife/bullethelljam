using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalData : MonoBehaviour
{ 
    private static Player _player;
    private void Start()
    {
        _player = FindObjectOfType<Player>();
    }
    public static Player Player
    {
        get => _player;
    }
}
