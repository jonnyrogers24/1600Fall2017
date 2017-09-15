using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ifOpenDoor : MonoBehaviour {
public Text input;
public bool canOpenDoor = false;
public string pin = "1212"; 
	
	void Update () {
		if(input.text == pin) {
			print("You May Enter");
			canOpenDoor = true; 
		}else{
			print("Enter 4-digit Pin");
		}
		
	}
}
