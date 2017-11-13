using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeVelocity : MonoBehaviour {

	public Rigidbody rb;

	void Start() {
		rb = GetComponent<Rigidbody>();
	}
	void FixedUpdate() {
		if (Input.GetButtonDown("Jump"))
			rb.velocity = new Vector3(0, 10, 0);

	}
}
