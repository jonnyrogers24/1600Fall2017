using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

	private CharacterController spaceShip; 
	public float moveSpeed; 
	public float playerRange;
	//public LayerMask playerLayer; 
	//public bool spaceshipInRange; 
	void Start () {
		

		//because the spaceship(player) has a CharacterController, the enemy is trying to find it. 
		spaceShip = FindObjectOfType<CharacterController>();
	}
	
	void Update () {
		//spaceshipInRange = Physics2D.OverlapCircle(transform.position, playerRange, playerLayer);
		//if(spaceshipInRange)
		{
		//the following is what tells th enemy player to reach, which are the data from the spaceship(player)
		transform.position = Vector3.MoveTowards (transform.position, spaceShip.transform.position, moveSpeed * Time.deltaTime);
		}
	}	

	//void OnDrawGizmosSelected()
	//{
	//	Gizmos.DrawSphere(transform.position, playerRange);
	//}
}
