using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchKinematic : MonoBehaviour {

	// Use this for initialization
	public float targetTime = 5.0f;

	private Rigidbody rb;

	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		targetTime -= Time.deltaTime;

		if(targetTime <= 0.0f) {
			rb.isKinematic = false;
		}
	}
}
