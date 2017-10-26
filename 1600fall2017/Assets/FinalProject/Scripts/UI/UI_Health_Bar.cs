using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class UI_Health_Bar : MonoBehaviour {

	public Image healthBar; 
	public float barTime = 0.1f;
	public float powerLevel = 0.1f; 
	public float amountToAdd = 0.01f;

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
		while (healthBar.fillAmount < 1)
		{
			healthBar.fillAmount += amountToAdd; 
			yield return new WaitForSeconds(barTime);
		}
	}

	IEnumerator PowerDownBar () {
		if (healthBar.fillAmount > 0.1f)
		{			
			healthBar.fillAmount += amountToSubtract;
			print(healthBar.fillAmount); 
			yield return new WaitForSeconds(barTime);
		}
		
	}	
}