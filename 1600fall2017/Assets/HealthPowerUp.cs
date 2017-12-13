using UnityEngine;

public class HealthPowerUp : MonoBehaviour {
	
	void OnTriggerEnter()
	{
		gameObject.SetActive(false);
	}
}
