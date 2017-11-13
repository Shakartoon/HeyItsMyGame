using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {
	public GameObject bulletPrefab; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space)) { 
			GameObject newBullet = Instantiate (bulletPrefab); 
		//	newBullet.transform.position = transform.position;
		//  1 unit unity wise is 1 meter 
			newBullet.transform.position = new Vector3 (
				transform.position.x, 
				transform.position.y + 0.1f); 

			Rigidbody rb = newBullet.GetComponent<Rigidbody> (); 
			rb.velocity = new Vector3 (0,1, 1); 
		} 

		
	}
}
