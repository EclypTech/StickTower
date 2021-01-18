using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{ 
    protected Joystick joystick;
    protected JoyButton joybutton;
    public int speed;
    public int jumpspeed;
    public bool jump;


    private bool isGrounded;
    public Transform groundcheck;
    public float checkRadius;
    public LayerMask whatisGround;



    // Start is called before the first frame update
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        joybutton = FindObjectOfType<JoyButton>();
    
    }


    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundcheck.position, checkRadius, whatisGround);

        var rigidbody = GetComponent<Rigidbody2D>();

        rigidbody.velocity = new Vector2(joystick.Horizontal * speed, rigidbody.velocity.y);

        if (isGrounded == true)
        {

            if (!jump && joybutton.Pressed)
            {
                if (rigidbody.velocity.y == 0)
                {
                    jump = true;
                    rigidbody.velocity += Vector2.up * jumpspeed;
                }
                
            }

            if (jump && !joybutton.Pressed)
            {
                jump = false;
            }
        }
        else
        {
            jump = false;
        }



    }


}
