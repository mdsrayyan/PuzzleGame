using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour {
	public float RotateSpeed = 10f;
	public float MoveSpeed = 5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// Amount to Move
		float MoveForward = Input.GetAxis("Vertical") * MoveSpeed * Time.deltaTime;
		float MoveRotate = Input.GetAxis("Horizontal") * RotateSpeed * Time.deltaTime;


		// Move the player
		transform.Translate(Vector3.forward * MoveForward);
		transform.Rotate(Vector3.up * MoveRotate);
	}
}
