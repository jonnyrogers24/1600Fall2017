using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnackCloset : MonoBehaviour {

	public int Jars = 4;
	

	void Start () {
		print("The snack closet has " + Jars + " snack jars!");	

		string[] snack = new string[4]; 

			snack[0] = "Cookie Jar";
			snack[1] = "Liquorice Jar";
			snack[2] = "Chocolate Jar";
			snack[3] = "Rice Crispie Jar";
		
		print(snack[0]);
		print(snack[1]);
		print(snack[2]);
		print(snack[3]);
	}

}
