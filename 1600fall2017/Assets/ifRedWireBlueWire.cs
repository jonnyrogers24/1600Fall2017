using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ifRedWireBlueWire : MonoBehaviour {
public Text input; 

public bool bombDisarmed = false; 

private string rightWire = "red";
private string wrongWire = "blue";
	// Update is called once per frame
	void Update () {
		if(input.text == rightWire) {
			print("Bomb Disarmed");
			bombDisarmed = true; 
		}
		if(input.text == wrongWire) {
			print("BOOM! You're Dead!");
		}
	}
}
