using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

	private GameObject spaceShip; 
	public float moveSpeed; 

	void Start()
		{
			spaceShip = GameObject.FindGameObjectWithTag("Player");
		}
	void Update () 
	{
		{
		//the following is what tells the enemy player to reach, which is the data from the spaceship(player)
		transform.position = Vector3.MoveTowards (transform.position, spaceShip.transform.position, moveSpeed * Time.deltaTime);
		}
	}	
}
