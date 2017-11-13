using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMouseLook: MonoBehaviour {

Vector2 mouseLook; 
Vector2 smoothV; 
public float sensitivity = 5.0f; 
public float smoothing = 2.0f; 

public GameObject player; 

	public float maxRotation = 5f; 


	// Use this for initialization
	void Start () {
//		player = this.transform.parent.gameObject; 
	}
	
	// Update is called once per frame
	void Update () {

		var md = new Vector2 (Input.GetAxisRaw ("Mouse X"), Input.GetAxisRaw ("Mouse Y")); 

//		var md = new Vector2 (ForceMode2D, new Vector2 (sensitivity + smoothing, sensitivity * smoothing)); 
		//		var md = new Vector2 (ForceMode2D, new Vector2 (sensitivity + smoothing, sensitivity * smoothing)); 
		md = Vector2.Scale (md, new Vector2 (sensitivity * smoothing, sensitivity *smoothing)); 
		smoothV.y = Mathf.Lerp (smoothV.y, md.y, 6f / smoothing); 
		smoothV.x = Mathf.Lerp (smoothV.x, md.x, 6f / smoothing); 
		mouseLook += smoothV; 

		if (mouseLook.y >= maxRotation) {
			mouseLook.y = maxRotation; 
		}

		if (mouseLook.y <= -maxRotation) {
			mouseLook.y = -maxRotation; 
		}
			
		transform.localRotation = Quaternion.AngleAxis (-mouseLook.y, Vector3.right); 
		player.transform.localRotation =  Quaternion.AngleAxis (mouseLook.x, player.transform.up); 

	}
}

