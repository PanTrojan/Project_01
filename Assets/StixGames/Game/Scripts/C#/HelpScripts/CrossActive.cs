using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossActive : MonoBehaviour {

	public static bool active = true;
	public GameObject cross;

	void Update () {
		if (active) {
			cross.SetActive (true);
		} else if(!active) {
			cross.SetActive (false);
		}
	}
}
