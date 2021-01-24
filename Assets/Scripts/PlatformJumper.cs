using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformJumper : MonoBehaviour
{

    // Player jump part.
    public float jumpForce = 10f;  // Determine current force.

    private void OnCollisionEnter2D(Collision2D collision)  // When touch..
    {
        if(collision.relativeVelocity.y <= 0f)  // If statement to block infinite jump.
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>(); // Determine which colliders touch.
            if (rb != null)  // If touch..
            {
                Vector2 velocity = rb.velocity;  // Determine vector velocity for Rigidbody.
                velocity.y = jumpForce;  // Add vertical force to velocity.
                rb.velocity = velocity;  // Equal this vertical velocity to Rigidbody velocity.
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
