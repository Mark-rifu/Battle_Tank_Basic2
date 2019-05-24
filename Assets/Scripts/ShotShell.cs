using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotShell : MonoBehaviour {


	public GameObject shellPrefab;
	public float shotSpeed;
	//public AudioClip shotSound;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			GameObject shell = Instantiate (shellPrefab, transform.position, Quaternion.identity) as GameObject;
			Rigidbody shellRb = shell.GetComponent<Rigidbody> ();
			shellRb.AddForce (transform.forward * shotSpeed);
			Destroy (shell, 3.0f);
			//AudioSource.PlayClipAtPoint (shotSound, transform.position);
		}
	}
}
