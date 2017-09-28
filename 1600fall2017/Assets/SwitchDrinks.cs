using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchDrinks : MonoBehaviour {

	public string[] drinks; 
	
	// Update is called once per frame
	public void MyDrinkSwitch (int i) {
		switch (drinks[i])
		{
			case "Soda Pop":
				print("Soda Pop");
				break; 

			case "Juice":
				print("Juice");
				break;

			case "Water":
				print("Water");
				break;
			
			default:
				print("You have no other drinks");
				break;

		}
	}		
}
