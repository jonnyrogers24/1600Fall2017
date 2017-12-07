using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class AsteroidDestroy : MonoBehaviour 
{
	public GameObject explosion;   
  
	void OnTriggerEnter (Collider other)
		{
			if (other.tag == "BoundaryBox")
			{
				return;   
			}
			if ( other.tag == "Enemy")
			{
				return; 
			}
	
			Instantiate (explosion, transform.position, transform.rotation);
            Destroy(other.gameObject);
			Destroy(gameObject);
        }
    }





