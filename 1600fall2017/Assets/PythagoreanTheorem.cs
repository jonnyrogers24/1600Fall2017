using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script uses the pothagorean theorem formula which is a^2 + b^2 = c^2
public class PythagoreanTheorem : MonoBehaviour {

	// Use this for initialization
	public int sideA;
	public int sideB;
	public int hypotenuseC;
	private int aSquared;
	private int bSquared;
	private int cSquared;

	// Update is called once per frame
	void Update () {
		aSquared = sideA * sideA;
		bSquared = sideB * sideB;
		cSquared = aSquared + bSquared;
		hypotenuseC = cSquared;
			print("YOU DID IT");
	}
}
