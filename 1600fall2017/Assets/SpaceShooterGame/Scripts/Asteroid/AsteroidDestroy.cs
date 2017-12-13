using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class AsteroidDestroy : MonoBehaviour 
{
	public int amountToSubtract = -20;   
	//public GameObject explosion;
  
	void OnTriggerEnter (Collider other){
		{
			PlayerHealthSlider.health += amountToSubtract;
		}
	}

			//if (other.tag == "BoundaryBox")
			//{
				//return;   
			//}
			//if ( other.tag == "Enemy")
			//{
			//	return; 
			//}
	
			//Instantiate (explosion, transform.position, transform.rotation);
			//Destroy(gameObject);
        //}
    }





