using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankHealth : MonoBehaviour {

	public GameObject effectPrefab1;
	public GameObject effectPrefab2;
	public int tankHP;


	void OnTriggerEnter(Collider other){

		if(other.CompareTag("EnemyShell")){
			tankHP -= 1;
			Destroy(other.gameObject);

			if (tankHP > 0) {
				GameObject effect1 = (GameObject)Instantiate (effectPrefab1, transform.position, Quaternion.identity);
				Destroy (effect1, 1.0f);
			}else{
				GameObject effect2 = (GameObject)Instantiate (effectPrefab2, transform.position, Quaternion.identity);
				Destroy (effect2, 1.0f);

				Destroy (gameObject);
			}

		}
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
