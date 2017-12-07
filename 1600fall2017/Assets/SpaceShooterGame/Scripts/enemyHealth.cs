using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class enemyHealth : MonoBehaviour {

public Image healthBar; 
public float maxHealth = 100f;
public float currentHealth = 0f;
void Start ()
	{
		currentHealth = maxHealth;
		SetHealthBar ();
	}

public void TakeDamage(float amount)
	{
		currentHealth -= amount; 
		SetHealthBar ();
	}

public void SetHealthBar()
	{
		float myHealth = currentHealth / maxHealth; 
		healthBar.transform.localScale = new Vector3 (Mathf.Clamp (myHealth, 0f, 1f), healthBar.transform.localScale.y, healthBar.transform.localScale.z);
	}

}
