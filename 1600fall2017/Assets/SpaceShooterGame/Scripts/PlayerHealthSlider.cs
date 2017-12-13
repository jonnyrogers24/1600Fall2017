using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHealthSlider : MonoBehaviour {

	public static int health = 100;
	public Slider healthBar;  
	public GameObject explosion; 
	void Start ()
	{
		
	}
	
	void ReduceHealth () 
	{
		healthBar.value = health; 
		if(health <=0)
		{
			Instantiate (explosion, transform.position, transform.rotation);
			Destroy(gameObject);
		}
	}
	void Update ()
	{

	}
}
