using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapBall : MonoBehaviour {

	public int force;
	// Use this for initialization
	void Start () {
		Debug.Log ("TapBall Start");
		transform.position = Camera.main.transform.position + (Camera.main.transform.forward * 1.5f);
	}
	
	// Update isai called once per frame
	void Update () {
		
	}

	// Called by GazeGestureManager when the user performs a Select gesture
	void OnSelect(RaycastHit hitInfo)
	{

		Debug.Log ("TapBall OnSelect");

		// If the sphere has no Rigidbody component, add one to enable physics.
		if (!this.GetComponent<Rigidbody>())
		{
			var rigidbody = this.gameObject.AddComponent<Rigidbody>();
			rigidbody.collisionDetectionMode = CollisionDetectionMode.Continuous;
		}

		GetComponent<Rigidbody>().AddForce(-hitInfo.normal * force);
	}

}
