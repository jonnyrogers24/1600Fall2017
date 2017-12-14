using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDownMove : MonoBehaviour {

private GameObject Player; 
public GameObject explosion; 
	public float moveSpeed; 

	void Start()
		{
			Player = GameObject.FindGameObjectWithTag("Player");
		}
	 void Update () 
	{
		//the following is what tells the enemy player to reach, which is the data from the spaceship(player)
		transform.position = Vector3.MoveTowards (transform.position, Player.transform.position, moveSpeed * Time.deltaTime);		
	}

			
}
