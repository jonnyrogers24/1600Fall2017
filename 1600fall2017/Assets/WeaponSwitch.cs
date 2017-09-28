using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitch : MonoBehaviour {

	public string[] weapons;

	public void MyWeaponSwitch (int i){
		switch (weapons[i])
		{
			case "Missile":
				print("Missile");
				break;

			case "Plasma":
				print("Plasma");
				break;
				
			case "Gun":
				print("Gun");
				break;
			
			default:
			 print("You have no other weapons.");
			 break;
		}
	}
} 
