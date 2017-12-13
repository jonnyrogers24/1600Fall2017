using UnityEngine;

public class Camera_Follow : MonoBehaviour {

	public Transform target; 
	public float speed = 0.125f; 
	public Vector3 offset; 

	void FixedUpdate ()
	{
		Vector3 desiredPostion = target.position + offset;
		Vector3 smoothedpostion = Vector3.Lerp (transform.position, desiredPostion, speed); 
		transform.position = smoothedpostion; 
		transform.LookAt(target);
	}
}
