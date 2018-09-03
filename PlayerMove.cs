using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	private CharacterController charController;
	public float WalkSpeed;
	// Use this for initialization
	void Awake () {
		charController = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		MovePlayer();
	}

	void MovePlayer(){
		float horiz  = Input.GetAxis("Horizontal");
		float vert = Input.GetAxis("Vertical");

		Vector3 moveDirSide = transform.right * horiz *  WalkSpeed;
		Vector3 moveDirForward = transform.forward * vert * WalkSpeed;

		charController.SimpleMove(moveDirSide);
		charController.SimpleMove(moveDirForward);

		if(Input.GetKeyDown("space")){

			transform.Translate(Vector3.up * 260 * Time.deltaTime, Space.World);
		}
	}
}
