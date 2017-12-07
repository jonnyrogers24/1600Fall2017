using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class EnemyDestroy : MonoBehaviour {
public GameObject explosion;  
  public GameObject Enemy;
	public Image healthBar; 
	public float barFillTime = 0.1f; 
	public float amountToAdd = 0.1f;
	public float amountToSubtract = -0.1f; 
	public enum PowerUpType
	{
		PowerDown,
	}
	
	void Start ()
	{
        Enemy = GameObject.FindGameObjectWithTag("Enemy");
    }
	public PowerUpType powerUp; 
	void OnTriggerEnter() {

		switch (powerUp)
		{
			case PowerUpType.PowerDown:
				StartCoroutine(PowerDownBar());
			break; 
		}
	}

	IEnumerator PowerDownBar () {
		if (healthBar.fillAmount > 0)
		{			
			healthBar.fillAmount += amountToSubtract;
			print(healthBar.fillAmount); 
			yield return new WaitForSeconds(barFillTime);
			
		}
	}
    private void Update()
    {
        if (healthBar.fillAmount == 0)
        {
			Instantiate (explosion, transform.position, transform.rotation);
            Enemy.SetActive(false);
        }
    }
}


