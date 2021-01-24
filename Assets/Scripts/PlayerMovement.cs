using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public int movementSpeed;  // Public movement speed.
	float moveInput;  // To determine direction. Only one ore minus one.
	Rigidbody2D rb;   // Determine Rigidbody to script.

	// Use this for initialization
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();  // Get Rigidbody at the beginning.
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
}
