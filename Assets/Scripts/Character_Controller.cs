using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Controller : MonoBehaviour {

	public float speed = 10.0F; 
	private Rigidbody rb;
	public bool onGround; 
	public float verticalVelocity; 
	public float gravity; 
	public float jumpForce; 

	public float groundDetectionDistance;
	public LayerMask groundLayer;

	private Animator anim;

	private Vector3 posLastFrame;

	void Start () {

		Cursor.lockState = CursorLockMode.Locked; 
		onGround = true; 
		rb = GetComponent<Rigidbody> ();
		anim = GetComponent<Animator> ();
	}
	
	void Update () {
		CheckIfGrounded ();
		float translation = Input.GetAxis ("Vertical") * speed; 
		float straffe = Input.GetAxis ("Horizontal") * speed; 
		translation *= Time.deltaTime; 
		straffe *= Time.deltaTime; 

		transform.Translate (straffe, 0, translation); 

		if (Input.GetKeyDown ("escape")) 
			Cursor.lockState = CursorLockMode.None; 

		if (Input.GetButtonDown ("Jump") && onGround == true) {

	//		rb.AddForce (Vector3.up * jumpForce, ForceMode.Impulse); 
	//		verticalVelocity = jumpForce; 
			rb.velocity += jumpForce * Vector3.up; 
			Debug.Log ("jump");
			onGround = false; 
		}

		rb.velocity += gravity * Vector3.down;
		Vector3 posDiff = transform.position - posLastFrame;
		float animVelocity = new Vector2 (posDiff.x, posDiff.z).magnitude;
		Debug.Log ("vel is " + animVelocity);
		anim.SetFloat ("Velocity", animVelocity);
		posLastFrame = transform.position;
	}

	void CheckIfGrounded(){
		Debug.DrawRay (transform.position, Vector3.down * groundDetectionDistance, Color.blue);
		if (Physics.Raycast (transform.position, Vector3.down, groundDetectionDistance, groundLayer)) {
			onGround = true;
		} else {
			onGround = false;
		}

	}
}