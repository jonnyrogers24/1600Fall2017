using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class LaserMover : MonoBehaviour {
	public float speed; 
void Start () 
		{
			GetComponent<Rigidbody>().velocity = transform.right * speed;
			//transform.right will make the laser move from the left of the screen to the right. 
			//* speed is then multiplied by the transform. in this case the speed is double that of the spaceship
		}
    }


	

