using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeSize : MonoBehaviour
{
    private void Start()
    {
        float scale = Random.Range(0.15f, 0.4f);
        transform.localScale = new Vector2(scale,scale);
    }
}
