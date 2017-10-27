using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class UI_Health_Bar : MonoBehaviour {
	public GameObject gameOverUI; 
	public Image healthBar; 
	public float barFillTime = 0.1f;
	public float powerLevel = 0.1f; 
	public float amountToAdd = 0.1f;
	public float amountToSubtract = -0.1f; 
	public enum PowerUpType
	{
		PowerUp,
		PowerDown
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

		if (healthBar.fillAmount == 0)
		{
			gameOverUI.SetActive(true);
			CharacterControl.gameOver = true; 
		}
		
	}	
}