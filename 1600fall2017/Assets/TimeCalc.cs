using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script is to calculate how long it would take me to travel a certain distance and a certain rate.

public class TimeCalc : MonoBehaviour {

	public int miles;
	public int mph;
	public int pitStopTime;
	public double hours;
	
	// Update is called once per frame
	void Update () {
		hours = (miles / mph) + pitStopTime;
	}
}
