using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    [SerializeField] private AudioSource _music;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if(GameObject.FindObjectsOfType<Music>().Length > 1)
        {
            Destroy(gameObject);
        }
    }
    private void OnEnable()
    {
        _music.Play();
    }
}
