using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CharacterMove : MonoBehaviour {

	public CharacterController characterController;
	public float gravity = 9.81f;
	public float speed = 12;
	public Vector3 moveVector3; 
	public float jumpForce = 20;  

	//laser variables
	public GameObject laser; 
	public Transform laserSpawn;
	public float fireRate;
	private float nextFire;  
	void Start () {

	}

	void Update ()
		{
			if(Input.GetButton("Fire1") && Time.time > nextFire) 
			{
				nextFire = Time.time + fireRate; 
			//instatiate will give us the new values for the vector3 and the quatornian when the lasers are activated by the player.
				Instantiate (laser, laserSpawn.position, laserSpawn.rotation);
				{
					return; 
				}
			}
		}
	void FixedUpdate () {
		//moveVector3.y -= gravity * Time.deltaTime;

		//if(characterController.isGrounded && !gameOver)
		//{
			//if(Input.GetKeyDown(KeyCode.Space))
			//{
			//	moveVector3.y = jumpForce * Time.deltaTime;
			//}
			
		
		//}
			moveVector3.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
			moveVector3.y = Input.GetAxis("Vertical") * speed * Time.deltaTime;
		 
		characterController.Move(moveVector3);

	}
}
