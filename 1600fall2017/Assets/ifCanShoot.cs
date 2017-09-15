using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ifCanShoot : MonoBehaviour {

	public Toggle safety;
	
	// Update is called once per frame
	void Update () {
		if(safety.isOn)
		{
			print("Safety Off, Shoot Gun");
		}else{
			print("Safety On, Can't Shoot Gun");
		} 

	}
}
