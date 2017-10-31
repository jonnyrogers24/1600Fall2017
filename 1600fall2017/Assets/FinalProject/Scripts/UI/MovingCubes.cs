using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCubes : MonoBehaviour {

	public Transform movingCube;
	public Transform position1;
	public Transform position2; 
	public Vector3 newPosition; 
	public string currentState; 
	public float smooth; 
	public float resetTime; 
	
	void Start () {
		ChangeTarget ();
	}
	
	void FixedUpdate () {
		movingCube.position = Vector3.MoveTowards (movingCube.position, newPosition, smooth * Time.deltaTime );
	}

	void ChangeTarget () {
		if (currentState == "Moving  to Position 1"){
			currentState = "Moving to Position 2"; 
			newPosition = position2.position; 
		}
		else if (currentState == "Moving to Position 2"){
			currentState = "Moving to Position 1";
			newPosition = position1.position; 
		}
		else if (currentState == ""){
			currentState = "Moving to Position 2";
			newPosition = position2.position;
		}
		Invoke ("ChangeTarget", resetTime);
	}
}
