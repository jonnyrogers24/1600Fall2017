using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookieJar : SnackCloset {

	public int totalCookies; 
	
	void Start () { 
		print("There are " + totalCookies + " cookies in the cookie jar!");
	}

}
