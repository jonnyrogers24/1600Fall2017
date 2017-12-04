using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI.Text;
public class ReplayGame : MonoBehaviour {

	public Transform player;  
    public GameObject Player1;
	public GameObject GameOverUI;
	public GameObject uiBar; 
	public Transform healthBar;  
	public static Vector3 startPosition; 
	private float fillAmount; 

	void Start()
	{
        Player1 = GameObject.FindGameObjectWithTag("Player");
		startPosition = player.position; 
		//fillAmount = uiBar.healthBar.fillAmount; 
		GameOverUI.SetActive(false);	
	} 

	public void Click () {
		CharacterControl.gameOver = false; 
		player.position = startPosition;
		//uiBar.healthBar.fillAmount = fillAmount; 
		GameOverUI.SetActive(false);
        Player1.SetActive(true);
	}
}
