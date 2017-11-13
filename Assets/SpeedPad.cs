using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPad : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider otherCollider){
		Character_Controller playerControl = otherCollider.gameObject.GetComponent<Character_Controller> ();//get ref to player character controller

		if (playerControl != null) { //was the variable filled?
			playerControl.speed = 200f;
		}
	}

	void OnTriggerExit(Collider otherCollider){
		Character_Controller playerControl = otherCollider.gameObject.GetComponent<Character_Controller> ();//get ref to player character controller

		if (playerControl != null) { //was the variable filled?
			playerControl.speed = 100f;
		}
	}
}
