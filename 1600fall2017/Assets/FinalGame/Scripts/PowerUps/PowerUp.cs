using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class PowerUp : MonoBehaviour {

public GameObject Player; 
public Slider healthBar;
public int amountToSubtract;
public int amountToAdd; 
public enum PowerUpType
	{
		PowerUp,
		PowerDown,
	}
public PowerUpType powerUp;
	void OnTriggerEnter(Collider Other)
	{
		switch (powerUp)
		{
			case PowerUpType.PowerUp:
				StartCoroutine(PowerUpBar());
			break;

			case PowerUpType.PowerDown:
				StartCoroutine(PowerDownBar());
			break;  
		}	
	}
	IEnumerator PowerUpBar()
	{
		if(PlayerManager.health < 100 )
		{
			healthBar.value = PlayerManager.health;
			PlayerManager.health += amountToAdd;
			print(PlayerManager.health);
			yield return new WaitForSeconds(PlayerManager.health); 
		}
	}
	IEnumerator PowerDownBar()
	{
		if(PlayerManager.health > 0 )
		{
			healthBar.value = PlayerManager.health;
			PlayerManager.health -= amountToSubtract;
			print(PlayerManager.health);
			yield return new WaitForSeconds(PlayerManager.health); 
		}
	}
	
	// Update is called once per frame
	void Update () {

		if(PlayerManager.health <= 0)
		{
			 Player.SetActive(false);
		}
	}
}
