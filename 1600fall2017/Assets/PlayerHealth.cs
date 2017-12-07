﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class PlayerHealth : MonoBehaviour {

public GameObject explosion;  
  public GameObject Player;
	public Image healthBar; 
	public float barFillTime = 0.1f; 
	public float amountToAdd = 0.1f;
	public float amountToSubtract = -0.1f; 
	public enum PowerUpType
	{
		PowerUp,
		PowerDown,
		Win,
	}
	void Start ()
	{
        Player = GameObject.FindGameObjectWithTag("Player");
    }
	public PowerUpType powerUp; 
	void OnTriggerEnter() {

		switch (powerUp)
		{
			case PowerUpType.PowerUp:
				StartCoroutine(PowerUpBar());
			break;

			case PowerUpType.PowerDown:
				StartCoroutine(PowerDownBar());
			break; 
			//case PowerUpType.Win:
				//EndGame("You Win");
			//break; 
		}
	}

	IEnumerator PowerUpBar () {
		if (healthBar.fillAmount < 1)
		{
			healthBar.fillAmount += amountToAdd; 
			yield return new WaitForSeconds(barFillTime);
		}
	}

	IEnumerator PowerDownBar () {
		if (healthBar.fillAmount > 0)
		{			
			healthBar.fillAmount += amountToSubtract;
			print(healthBar.fillAmount); 
			yield return new WaitForSeconds(barFillTime);
			
		}

		//if (healthBar.fillAmount == 0)
	//	{
	//		EndGame("Game Over"); 
	//	}
		
	}
    private void Update()
    {
        if (healthBar.fillAmount == 0)
        {
			Instantiate (explosion, transform.position, transform.rotation);
            Player.SetActive(false);
        }
    }
}



