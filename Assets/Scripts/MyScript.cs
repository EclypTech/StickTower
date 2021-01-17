using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{ 
    protected Joystick joystick;
    protected JoyButton joybutton;
    public int speed;
    public int jumpspeed;
    protected bool jump;

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

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundcheck.position, checkRadius, whatisGround);

        var rigidbody = GetComponent<Rigidbody2D>();

        rigidbody.velocity = new Vector2(joystick.Horizontal * speed, rigidbody.velocity.y);

        if (isGrounded == true)
        {
            if (!jump && joybutton.Pressed)
            {
                jump = true;
                rigidbody.velocity += Vector2.up * jumpspeed;


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
