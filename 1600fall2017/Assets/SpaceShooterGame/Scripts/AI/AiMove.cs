using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; 
public class AiMove : MonoBehaviour 
{
	private NavMeshAgent enemyAgent; 
	public Transform target; 

	void Start ()
	{
		enemyAgent = GetComponent<NavMeshAgent>(); 
	}

	void Update ()
	{
		enemyAgent.SetDestination (target.position);
	}
}
