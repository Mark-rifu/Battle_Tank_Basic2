using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShotShell : MonoBehaviour {


	public GameObject enemyShellPrefab;
	public float shotSpeed;
	//public AudioClip shotSound;
	private float shotInterval;

	// Use this for initialization

	
	// Update is called once per frame
	void Update () {

		shotInterval += 1;

		if(shotInterval % 30  == 0){
			GameObject enemyShell = (GameObject)Instantiate (enemyShellPrefab, transform.position, Quaternion.identity);
			Rigidbody enemyShellRb = enemyShell.GetComponent<Rigidbody> ();
			enemyShellRb.AddForce (transform.forward * shotSpeed);
			//AudioSource.PlayClipAtPoint (shotSound, transform.position);
			Destroy (enemyShell, 3.0f);
	}
}
}