using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ifMillionDollarQuestion : MonoBehaviour {

public Text input;
public bool canWin = false; 
public string number = "2";

void update () {
		if(input.text == number) {
			print("Congrats! You Won A Million Chrute Bucks!!"); 
			canWin = true; 
		} else {
			print("Sorry, you lost. Thanks for playing!");
		}
	}		
}
