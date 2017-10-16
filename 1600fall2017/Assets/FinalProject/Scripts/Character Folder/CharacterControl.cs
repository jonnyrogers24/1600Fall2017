﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour {

	public CharacterController characterController;
	public float gravity = 9.81f;
	public float speed = 12;
	public Vector3 moveVector3; 
	public float jumpForce = 20;  
	void Start () {

	}


	void FixedUpdate () {
		moveVector3.y -= gravity * Time.deltaTime;

		if(characterController.isGrounded)
		{
			if(Input.GetKey(KeyCode.Space))
			{
				moveVector3.y += jumpForce * Time.deltaTime;
			}
			
		
			moveVector3.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
		}
		 
		characterController.Move(moveVector3);

	}
}