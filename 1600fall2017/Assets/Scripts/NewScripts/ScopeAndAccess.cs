using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAndAccess : MonoBehaviour {

	private int health = 100;

	public int score = 100;

	void Start () {
		
		int newScore = 10;
		print(newScore);

	}

}