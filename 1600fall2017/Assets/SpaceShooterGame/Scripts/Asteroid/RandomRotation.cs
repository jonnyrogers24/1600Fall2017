using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotation : MonoBehaviour 
{
	public float rotate;

	void Start ()
	{
		GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * rotate; 
	}

}
