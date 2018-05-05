using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	CharacterController characterController;

	public float walkSpeed;

	void Awake(){
		characterController = GetComponent<CharacterController> ();
	}

	void Update(){
		MovePlayer ();
	}

	void MovePlayer(){
		float horiz = Input.GetAxis ("Horizontal");
		float vert = Input.GetAxis ("Vertical");

		Vector3 moveDirSide = transform.right * horiz * walkSpeed;
		Vector3 moveDirForward = transform.forward * vert * walkSpeed;

		characterController.SimpleMove (moveDirSide);
		characterController.SimpleMove (moveDirForward);

	}

}
