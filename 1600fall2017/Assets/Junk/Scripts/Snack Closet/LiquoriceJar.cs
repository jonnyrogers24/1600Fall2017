using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiquoriceJar : SnackCloset {

	public int totalLiquorice = 30;

	void Start () {
		print("There are " + totalLiquorice + " liquorice in the liquorice jar!");
	}
}