using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(AudioSource))]

public class PlayerController : MonoBehaviour
{
	//	public void AddForce (Vector3 force, ForceMode mode = ForceMode.Force);
	private Rigidbody rb;
	public float speed = 500;
	public AudioSource leftSound;


	public bool onGround; 
	public float verticalVelocity; 
	public float gravity = 4.0f; 
	public float jumpForce = 50.0f; 

	void Start ()
	{ 

		onGround = true; 
		rb = GetComponent<Rigidbody> (); 
//		ControllerColliderHit = GetComponent<CharacterController>(); 
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal"); 
		float moveVertical = Input.GetAxis ("Vertical"); 
		  
		//	Vector3 movement = new Vector3 (moveHorizontal, 0, moveVertical); 

//		rb.AddForce (Vector3);  

//		rb.velocity = new Vector3 (0, 0, 0); 
		Vector3 force = new Vector3(moveHorizontal * speed, 0f, moveVertical * speed);
		rb.AddForce(force,ForceMode.Impulse); 
		Debug.Log ("horizontal axis: " + moveHorizontal);
		Debug.Log ("vertical axis: " + moveVertical);

//
//		if (Input.GetKey (KeyCode.UpArrow)) { 
//////			SpriteRenderer.flipX = true; 
//			rb.velocity = new Vector3 (0, 0, speed); 
////		} 
//
////
//		if (Input.GetKey (KeyCode.LeftArrow)) { 
////			//			SpriteRenderer.flipX = true; 
//	//		rb.rotation =  Quaternion.AngleAxis (speed, Vector3.up );   
//			rb.velocity = new Vector3 (speed, 0, 0); 
//
////			leftSound.Play (); 
//		} 
//
////
//		if (Input.GetKey (KeyCode.RightArrow)) { 
////			//			SpriteRenderer.flipX = true; 
//			rb.velocity = new Vector3 (speed, 4, 4); 
////		
//	  } 

	}
	void Update() {


		if (Input.GetButtonDown ("Jump") && onGround == true) {

	//		rb.velocity = new Vector3 (3f, 4f, 4f); 

			rb.AddForce (Vector3.up * jumpForce, ForceMode.Impulse); 
			verticalVelocity = jumpForce; 
			onGround = false; 
		}
		
//		if (Input.GetKeyDown (KeyCode.Space)) {
//			verticalVelocity = Time.deltaTime; 
//			verticalVelocity = jumpForce;
//		

}
			
	void OnCollisionEnter(Collision other) {
		
		if (other.collider.gameObject.CompareTag ("Ground")) {
		
			onGround = true; 
			Debug.Log ("Hey"); 
		} else {
			Debug.Log ("colliding with " + other.collider.gameObject.name); 
		} 
			
	} 


} 
