using UnityEngine;
using System.Collections;

public class csCCMove : MonoBehaviour {


	public float movSpeed = 5.0f;
	public float rotSpeed = 120.0f;


	CharacterController controller;
	Vector3 moveDirection;


	float jumpSpeed = 10.0f;
	float gravity = 20.0f;

	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
			//float amtMove = movSpeed * Time.deltaTime;
			float amtRot = rotSpeed * Time.deltaTime;

			float ver = Input.GetAxis ("Vertical");
			float ang = Input.GetAxis ("Horizontal");


			//transform.Rotate (Vector3.up * ang * amtRot);

		moveDirection = new Vector3 (ang * movSpeed,0 , ver * movSpeed);
			moveDirection = transform.TransformDirection (moveDirection);



		if (Input.GetButtonDown ("Jump")) {
			moveDirection.y = jumpSpeed;
		}


		moveDirection.y -= (gravity * Time.deltaTime);

		controller.Move (moveDirection * Time.deltaTime);

	}
}
