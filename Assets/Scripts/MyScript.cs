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


    //Stamina bar part.
    public int maxStamina = 100;
    public int currentStamina;
    public StaminaBar staminaBar;


    void Start()
    {
        joystick = FindObjectOfType<Joystick>();    // Call Joystick button function from JoyButton.cs
        joybutton = FindObjectOfType<JoyButton>();  // Call Joybutton button function from JoyButton.cs

        currentStamina = maxStamina;              //Max stamina equal to 100.
        staminaBar.SetMaxStamina(maxStamina);     //Stamina equal to max stamina at the beggining of game.
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundcheck.position, checkRadius, whatisGround);  //Add overlap circle to trigger player.

        var rigidbody = GetComponent<Rigidbody2D>(); // Define our rigidbody component.

        rigidbody.velocity = new Vector2(joystick.Horizontal * speed, rigidbody.velocity.y); //Create new velocity vector to our rigidbody.

        if (isGrounded == true) // If statement triggered when rigidbody detect ground(platform).
        {

            if (!jump && joybutton.Pressed) // If player dont flying and press joybutton..
            {
                if (rigidbody.velocity.y == 0) // If rigidbody(player) dont have any vertical force..
                {
                    jump = true;  // Jump = true so player can jump.
                    rigidbody.velocity += Vector2.up * jumpspeed; // Add jump velocity to our rigidbody vector.
                }       
            }

            if (jump && !joybutton.Pressed) // 43. satýrda eklediðimiz If statement 
                                           // sayesinde buna gerek kalmamýþ olabilir.
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
