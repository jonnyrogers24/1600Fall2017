using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchUtensiles : MonoBehaviour {

	public string[] Utensiles;

	public void MyUtensilesSwitch (int i) {
		switch (Utensiles[i])
		{
			case "Fork":
				print("Fork");
				break;
			
			case "Spoon":
				print("Spoon");
				break;
			
			case "Knife":
				print("Knife");
				break;
		}
	}

}
