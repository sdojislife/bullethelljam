using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCancel : MonoBehaviour
{
    public void OnDestroy()
    {
        Projectile[] bullets = FindObjectsOfType<Projectile>();
        foreach(Projectile projectile in bullets)
        {
            if(projectile.gameObject.layer == 8)
            {
                Destroy(projectile.gameObject);
            }
        }
    }
}
