using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public int movementSpeed;  // Public movement speed.
	float moveInput;  // To determine direction. Only one ore minus one.
	Rigidbody2D rb;   // Determine Rigidbody to script.

	public int MoveStarCounter;

	Animator animator;
	public int animcount = 0;

	// Use this for initialization
	void Start()
	{
		Load();
		rb = GetComponent<Rigidbody2D>();  // Get Rigidbody at the beginning.
		animator = GetComponent<Animator>();

		movementSpeed = 4 + MoveStarCounter;

		Save();
	}


	// Update is called once per frame
	void FixedUpdate()
	{
		rb.velocity = new Vector2(moveInput * movementSpeed, rb.velocity.y);  // Update Rigidbody velocity vector every time. 
	}

	public void MoveRight() //Right function. Interact with the right button in unity.
    {
		moveInput = 1;
    }

	public void MoveLeft()  //Left function. Interact with the left button in unity.
	{
		moveInput = -1;
	}

	public void MoveStop()  //Stop function. Interact with the bought of the buttons in unity.
	{
		moveInput = 0;
	}


	private void OnCollisionEnter2D(Collision2D collision) // Animation Jump.
	{
		if (collision.relativeVelocity.y >= 0f) 
		{
			Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>(); 
			if (collision.transform.tag == "platform")  
			{
				if(animcount == 0)
                {
					animcount = 1;
					animator.SetTrigger("IsJump1");
                }
				else if(animcount == 1)
                {
					animcount = 0;
					animator.SetTrigger("IsJump2");
				}



			}
		}
	}


    public void Load()
    {
		movementSpeed = PlayerPrefs.GetInt("movementSpeed");
		MoveStarCounter = PlayerPrefs.GetInt("MoveStarCounter");
	}

	public void Save()
	{
		PlayerPrefs.SetInt("movementSpeed", movementSpeed);
		PlayerPrefs.SetInt("MoveStarCounter", MoveStarCounter);
	}
}
