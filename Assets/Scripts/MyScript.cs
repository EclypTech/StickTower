using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{ 
    protected Joystick joystick;
    protected JoyButton joybutton;
    public int speed;
    protected bool jump;

    // Start is called before the first frame update
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        joybutton = FindObjectOfType<JoyButton>();
    
    }

    // Update is called once per frame
    void Update()
    {
        var rigidbody = GetComponent<Rigidbody2D>();

        rigidbody.velocity = new Vector2(joystick.Horizontal * speed, rigidbody.velocity.y);

        if (!jump && joybutton.Pressed)
        {
            jump = true;
            rigidbody.velocity += Vector2.up * speed;

        }

        if(jump && !joybutton.Pressed)
        {
            jump = false;
        }

    }

    




}
