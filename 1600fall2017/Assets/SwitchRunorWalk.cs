using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchRunorWalk : MonoBehaviour {

	public string[] Action;

	public void MyActionsSwitch (int i) {
		switch(Action[i])
		{
			case "Running":
				print("Running");
				break;

			case "Walking":
				print("Walking");
				break;
			
			case "Nothing":
				print("You Lazy Bum");
				break;
		}
			
	}
}
