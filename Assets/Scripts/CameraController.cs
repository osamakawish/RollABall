using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;
	private Vector3 offsetPosition;
	//private Vector3 offsetRotation;

	// Use this for initialization
	void Start () {
		offsetPosition = transform.position - player.transform.position;
		// Change offsetRotation.
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = player.transform.position + offsetPosition;
	}
}
