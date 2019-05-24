using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radar : MonoBehaviour {


	public Transform target;

	void OnTriggerStay(Collider other){
		if (other.CompareTag ("Player")) {
			transform.root.LookAt (target);
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
