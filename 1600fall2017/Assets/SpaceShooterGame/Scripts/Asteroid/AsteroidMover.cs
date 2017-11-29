using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMover : MonoBehaviour {

	public Transform movingAsteroid;
	public Transform position1;
	public Transform position2; 
	public Vector3 newPosition; 
	public string currentState; 
	public float smooth; 
	public float resetTime;

    private string pos1 = "Moving to Position 1";
    private string pos2 = "Moving to Position 2";

    
	
	void Start () {
		ChangeTarget ();
	}
	
	void FixedUpdate () {
       
		movingAsteroid.position = Vector3.MoveTowards (movingAsteroid.position, newPosition, smooth * Time.deltaTime );
	}

	void ChangeTarget ()
    {
		if (currentState == pos1)
        {
			currentState = pos2; 
			newPosition = position2.position;
		}
		else if (currentState == pos2)
        {
			currentState = pos1;
			newPosition = position1.position;
        }
		else if (currentState == "")
        {
			currentState = pos2;
			newPosition = position2.position;
		}
		Invoke ("ChangeTarget", resetTime);
	}
}

