using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 6 && gameObject.layer == 9)
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.layer == 10 && gameObject.layer == 9)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "MainCamera")
        {
            Destroy(gameObject);
        }
    }
}
