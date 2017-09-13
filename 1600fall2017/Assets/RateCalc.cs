using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script is the rate = distance / time formula. Rate will be calculated hen given distance and time. 
public class RateCalc : MonoBehaviour {

	public float milesTraveled;
	public float hoursTraveled;
	public float mph;
		
	// Update is called once per frame
	void Update () {
		mph = milesTraveled / hoursTraveled;
		
	}
}
