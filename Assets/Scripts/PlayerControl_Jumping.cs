using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl_Jumping : MonoBehaviour {


	public float speed; 
	public float rotSpeed; 
	public float jumpHeight; 

	public bool isGrounded; 

	Rigidbody rb; 

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody> (); 
		isGrounded = true; 
		
	}
	
	// Update is called once per frame
	void Update () {

		var y = Input.GetAxis ("Horizontal") * rotSpeed; 
		var z = Input.GetAxis ("Vertical") * speed; 

		transform.Translate (0, 0, z); 
		transform.Rotate (3, y, 3); 

		if (Input.GetKey (KeyCode.Space)) {
			rb.AddForce (0, jumpHeight * 4, 0); 
			transform.Translate (0, 0, 2); 
		} 
	}


	void OnCollisionEnter(Collision col) 
	{


	}

}
