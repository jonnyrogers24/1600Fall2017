using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HourlyWages : MonoBehaviour {

public float payPerHour;
public float hoursWorked;
public float totalPay;
	
	// Update is called once per frame
	void Update () {
		totalPay = hoursWorked * payPerHour;
		print("CA-CHING! WE RICH BABY");
	}
}
