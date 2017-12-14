using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour {

public GameObject Player; 
void OnTriggerEnter(Collider other) 
	{
		Player.SetActive(false);
		
	}
}
