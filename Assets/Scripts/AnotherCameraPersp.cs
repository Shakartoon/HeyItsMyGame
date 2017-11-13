using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherCameraPersp : MonoBehaviour {
	public GameObject player; 

	// Use this for initialization
	void LateUpdate() {
		transform.LookAt(player.transform);
	}
}
