using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SidetoSide : MonoBehaviour {

	private Vector3 pos1 = new Vector3 (-1, 0, 1); 
	private Vector3 pos2 = new Vector3 (1, 0, 1); 
	public float speed = .05f; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(transform.parent != null)
			transform.position = transform.parent.position + Vector3.Lerp (pos1, pos2, Mathf.PingPong (Time.time * speed, 1.0f)); 


	}
		
	}
