﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class YouWin : MonoBehaviour {

public Text winText;
	void OnTriggerEnter(Collider other)
	{
		winText.text = "You Win"; 
	}
}
