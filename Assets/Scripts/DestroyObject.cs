﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour {

	public GameObject effectPrefab;
	public GameObject effectPrefab2;

	public int objectHP;

	void OnTriggerEnter(Collider other){
		if (other.CompareTag ("Shell")) {
			objectHP -= 1;
			if (objectHP > 0) {
				Destroy (other.gameObject);
				GameObject effect = (GameObject)Instantiate (effectPrefab, transform.position, Quaternion.identity);
				Destroy (effect, 2.0f);

			}else{
			Destroy (other.gameObject);
				GameObject effect2 = (GameObject)Instantiate (effectPrefab2, transform.position, Quaternion.identity);
				Destroy (effect2, 2.0f);

			Destroy (this.gameObject);
			
			
		}

	
	}


}
}
