using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformJumper : MonoBehaviour
{
    // Player jump part.
    public int jumpForce;  // Determine current force.

    public int JumpStarCounter;

    private void OnCollisionEnter2D(Collision2D collision)  // When touch..
    {
        if(collision.relativeVelocity.y <= 0f)  // If statement to block infinite jump.
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>(); // Determine which colliders touch.
            if (collision.transform.tag == "Player")  // If touch..
            {
                GameObject SFX = GameObject.Find("SFX");
                SFX.GetComponent<SoundEffects>().Pick();
                Vector2 velocity = rb.velocity;  // Determine vector velocity for Rigidbody.
                velocity.y = jumpForce;  // Add vertical force to velocity.
                rb.velocity = velocity;  // Equal this vertical velocity to Rigidbody velocity.
            }
        }
    }

    void Start()
    {
        Load();
        jumpForce = 11 + JumpStarCounter;
        Save();
    }

    void Update()
    {
        
    }


    public void Save()
    {
        PlayerPrefs.SetInt("jumpForce", jumpForce);
    }

    public void Load()
    {
        jumpForce = PlayerPrefs.GetInt("jumpForce");
        JumpStarCounter = PlayerPrefs.GetInt("JumpStarCounter");
    }

}
