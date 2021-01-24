using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformJumper : MonoBehaviour
{

    // Player jump part.
    public float jumpForce = 10f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                Vector2 velocity = rb.velocity;
                velocity.y = jumpForce;
                rb.velocity = velocity;
            }
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
