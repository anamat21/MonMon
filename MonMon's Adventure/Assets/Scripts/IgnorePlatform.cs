using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnorePlatform : MonoBehaviour
{

    public Collider2D player;
    public Collider2D monster;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(!collision.Equals(player))
        {
            Physics2D.IgnoreCollision(monster, collision.collider);
        }
    }
}
