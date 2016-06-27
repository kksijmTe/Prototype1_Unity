using UnityEngine;
using System.Collections;

public class csMove : MonoBehaviour {
	public float movSpeed = 5.0f;
	public float rotSpeed = 120.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		float amtMove = movSpeed * Time.deltaTime;
		float amtRot = rotSpeed * Time.deltaTime;

		float ver = Input.GetAxis ("Vertical");
		float ang = Input.GetAxis ("Horizontal");

		transform.Translate (Vector3.forward * ver * amtMove);
		transform.Rotate (Vector3.up * ang * amtRot);

	}
}
