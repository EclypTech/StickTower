using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public int movementSpeed;
	float moveInput;
	Rigidbody2D rb;

	// Use this for initialization
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}


	// Update is called once per frame
	void FixedUpdate()
	{
		rb.velocity = new Vector2(moveInput * movementSpeed, rb.velocity.y);
	}

	public void MoveRight()
    {
		moveInput = 1;
    }

	public void MoveLeft()
	{
		moveInput = -1;
	}

	public void MoveStop()
	{
		moveInput = 0;
	}
}
