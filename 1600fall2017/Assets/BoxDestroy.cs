﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDestroy : MonoBehaviour {
	public GameObject explosion; 
	void OnTriggerEnter(Collider other)
	{
		Instantiate (explosion, transform.position, transform.rotation);
	}
}
