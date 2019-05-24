using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour {

	public float moveSpeed;
	public float turnSpeed;
	private Rigidbody rb;
	private float movementInputValue;
	private float turnInputValue;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		Move ();
		Turn ();
	}

	void Move(){
		movementInputValue = Input.GetAxis ("Vertical");
		//垂直方向に仮装軸の値、-1〜1を返す
		Vector3 movement = transform.forward * movementInputValue * moveSpeed * Time.deltaTime;
		rb.MovePosition (rb.position + movement);
	}

	void Turn(){
		turnInputValue = Input.GetAxis ("Horizontal");
		//水平方向に仮装軸の値、-1〜1を返す
		float turn = turnInputValue * turnSpeed * Time.deltaTime;
		Quaternion turnRotation = Quaternion.Euler (0, turn, 0);
		//z軸を中心にz度、x軸をx度、y軸をy度（この順番）で回転する回転を返します。
		rb.MoveRotation (rb.rotation * turnRotation);
	}
}
