using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this can be used to calculate the value change of an item and the percent lost or gained. 
public class AbsoluteRelativeChange : MonoBehaviour {

public int newValue;
public int oldValue;
public float absoluteChange;
public float relativeChange;

	
	// Update is called once per frame
	void Update () {
		absoluteChange = newValue - oldValue;
		relativeChange = (absoluteChange / oldValue) * .100f;
	}
}
