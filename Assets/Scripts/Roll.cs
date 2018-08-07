using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roll : MonoBehaviour {

	private Vector3 previousPosition;

	private float radius;
	private float ballCircumference;

	// Use this for initialization
	void Start () {
		previousPosition = transform.position;
		radius = transform.localScale.x/2.0f;

		ballCircumference = 2.0f * Mathf.PI * radius;
	}
	
	// Update is called once per frame
	void Update () {

		float distanceX = transform.position.x - previousPosition.x;
		float distanceZ = transform.position.z - previousPosition.z;

		float completeRotationsX = distanceX / ballCircumference;
		float completeRotationsZ = distanceZ / ballCircumference;

		transform.Rotate (completeRotationsZ * 360, 0.0f, -completeRotationsX * 360, Space.World);
//		transform.eulerAngles = new Vector3(completeRotationsZ * 360, 0.0f, -completeRotationsX * 360);
//		Vector3 rotationAxis = Vector3.Cross(moveDelta.normalized, Vector3.forward);

//		transform.RotateAround(transform.position, rotationAxis, Mathf.Sin(moveDelta.magnitude*r*2.0f*Mathf.PI)*Mathf.Rad2Deg);

		previousPosition = transform.position;

	}
}
