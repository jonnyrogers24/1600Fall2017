using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChocolateJar : SnackCloset {

	public int totalChocolateBars = 15;
	
	void Start() {
		print("There are " + totalChocolateBars + " chocolate bars in the chocolate jar!");
	}
}
