using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Returns : MonoBehaviour {
	void Start () {
		myScore = ReturnNum (health, ammo);
		myPassword = ReturnPassword("hello");
	}
	
	public int myScore = 100; 

	public int health ; 
	public int ammo;

	public string myPassword = "Amanda224";
	int ReturnNum (int _num, int _num2) {
		return _num + _num2;
	}

	string ReturnPassword (string _login) {
		if(_login == "hello"){
			return "Password Correct";
		}else{
			return "Incorrect";
		}
	}
}
