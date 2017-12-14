using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class PowerUp : MonoBehaviour {
[SerializeField] private Transform player;

[SerializeField] private Transform respawnPoint;
public GameObject Player; 
public Slider healthBar;
public float amountToSubtract;
public float amountToAdd; 
public Text endGameText; 
public GameObject gameOverUI;
public enum PowerUpType
	{
		PowerUp,
		PowerDown,
		Win,
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
			
			case PowerUpType.Win:
				EndGame("You Win");
			break;
		}	
	}
	IEnumerator PowerUpBar()
	{
		if(healthBar.value < 1 )
		{
			
			healthBar.value = PlayerManager.health;
			PlayerManager.health += amountToAdd;
			print(PlayerManager.health);
			yield return new WaitForSeconds(PlayerManager.health); 
		}
	}
	IEnumerator PowerDownBar()
	{
		if(healthBar.value > 0 )
		{
			healthBar.value = PlayerManager.health - amountToSubtract;
			PlayerManager.health -= amountToSubtract;
			print(PlayerManager.health);
			yield return new WaitForSeconds(PlayerManager.health); 
		}
	}
	
	// Update is called once per frame
	void Update () {

		if(PlayerManager.health <= 0)
		{
			 player.transform.position = respawnPoint.transform.position; 
			 Player.SetActive(true);
		}
	}
	void EndGame (string _text)
		{
			endGameText.text = _text; 
			gameOverUI.SetActive(true);
			CharacterControl.gameOver = true;
		}
}

