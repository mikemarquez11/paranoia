using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
	public float forceValue;
	public float jumpValue;
	private Rigidbody rigidBody;
	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Jump") && Mathf.Abs (rigidBody.velocity.y) < 0.01f) {
			rigidBody.AddForce (Vector3.up * jumpValue, ForceMode.Impulse);
		}
	}

	void FixedUpdate () {
		rigidBody.AddForce (new Vector3(Input.GetAxis("Horizontal"),0,0) * forceValue);
	}

}
