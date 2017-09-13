using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeVolume : MonoBehaviour {

public int cubeWidth;

public int cubeHeighth;

public int cubeLength;

public int totalVolume; 

	
	// Update is called once per frame
	void Update () {
		totalVolume = cubeWidth * cubeHeighth * cubeLength;
	}
}
