using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Health_Bar : MonoBehaviour {

	public Image healthBar; 
	public float barTime = 0.1f;

	void OnTriggerEnter() {
		StartCoroutine(UpdateBar());
	}

	IEnumerator UpdateBar () {
		while (healthBar.fillAmount < 1)
		{
			healthBar.fillAmount 
			+= barTime; 
			yield return new WaitForSeconds(barTime);
		}
	}	

}
