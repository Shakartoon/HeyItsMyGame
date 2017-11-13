using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour {

	public GameObject objToDestroy; 
	public GameObject effect; 
	public AudioClip clip;  


	// Use this for initialization

	void Start(){
//		GetComponent<AudioSource> ().playOnAwake = false;
//		GetComponent<AudioSource> ().clip = leftFoot;

	}

	void OnTriggerEnter(Collider other) { 

//		if (other.gameObject.tag == "Player")
//			Instantiate (effect, objToDestroy.transform.position, objToDestroy.transform.rotation); 
//		Destroy (objToDestroy); 
//		GetComponent<AudioSource> ().Play ();
//		Debug.Log("Nurrrr");

		Debug.Log("Nurrrr");
		if (other.gameObject.CompareTag("Player")) {
			this.gameObject.SetActive (false); 
			GameObject obj = new GameObject ();
			AudioSource src = obj.AddComponent<AudioSource> ();
			src.clip = clip;
			src.Play ();
			Destroy (obj, clip.length);
		}
	} 

}
