using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnackThief : CookieJar {

		public int stolenCookie = 1;	
		public int cookiesRemaining; 
 

	void Start()
	{
		cookiesRemaining = totalCookies - stolenCookie; 
	}
}

