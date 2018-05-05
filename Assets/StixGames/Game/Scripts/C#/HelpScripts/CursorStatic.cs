using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorStatic : MonoBehaviour {

	public static bool active;

	void Update () {
		if(active){
			Cursor.lockState = CursorLockMode.None;
		}else{
			Cursor.lockState = CursorLockMode.Locked;
		}
	}
}
