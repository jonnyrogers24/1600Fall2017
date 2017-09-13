using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ifStatement : MonoBehaviour {

	public Text input;

	public bool canPlayGame = false;
	public string password = "hi5";

	void Update () {
		if(input.text == password) {
			print("You know the password.");
			canPlayGame = true;
		} else {
			print("The password is incorrect");
		}

		if(canPlayGame) {
			print("Playing Game"); 
		}	else {
			print("Can't play yet, Enter Password");
		}	

	}

}
	