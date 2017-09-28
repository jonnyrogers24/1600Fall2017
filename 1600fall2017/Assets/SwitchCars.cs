using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCars : MonoBehaviour {
		public string[] cars;
	
	// Update is called once per frame
	public void MyCarSwitch (int i) {
		switch (cars[i])
		{
			case "Lamborghini":
			 print("Lamborghini");
			 break;

			case "Ferrari":
				print("Ferrari");
				break;
			
			case "Koenigsegg Agera R":
				print("Koenigsegg Agera R");
				break;
			
			case "Toyota 4-Runner":
				print("Sorry Mr. Rogers, but your wife took that one grocery shopping. Lets pick another car!");
				break;

		}
	}	
}
