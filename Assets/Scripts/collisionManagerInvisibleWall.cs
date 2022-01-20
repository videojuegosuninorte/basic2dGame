using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionManagerInvisibleWall : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Player")
        {
            Physics2D.IgnoreCollision(collision.transform.GetComponent<Collider2D>(),
                GetComponent<Collider2D>());
        }
    }
}
