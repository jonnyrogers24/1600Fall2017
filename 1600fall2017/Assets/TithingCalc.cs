using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TithingCalc : MonoBehaviour {

public float payCheckAmount;
private float tithing = .10f;
public float totalTithing;
	
	// Update is called once per frame
	void Update () {
		totalTithing = payCheckAmount * tithing;
		print("Stay righteous Brother/Sister");
	}
}
