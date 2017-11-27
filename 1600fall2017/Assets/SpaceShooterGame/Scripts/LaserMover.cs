using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMover : MonoBehaviour 
{
		public float speed; 
		void Start () 
		{
			GetComponent<Rigidbody>().velocity = transform.right * speed;
			//transform.right with make the laser move from tghe left of the screen to the right. 
			//* speed is then multiplied by the transform. in this case the speed is double that of the spaceship
		}
}
