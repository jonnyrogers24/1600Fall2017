using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {
[SerializeField] private Transform player;
[SerializeField] private GameObject Player;
[SerializeField] private Transform respawnPoint; 
	void OnTriggerEnter(Collider other) 
	{
		player.transform.position = respawnPoint.transform.position; 
		Player.SetActive(true);
	}	
}
