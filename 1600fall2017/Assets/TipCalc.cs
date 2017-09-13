using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipCalc : MonoBehaviour {

	public float mealCost;
	private float tipPercent = 0.15f; 
	public float tipAmount; 
	public float totalBill;

	
	// Update is called once per frame
	void Update () {
		tipAmount = mealCost * tipPercent;
		 totalBill= mealCost + tipAmount;
		 	print("Leave the Restaurant");
	}
}
