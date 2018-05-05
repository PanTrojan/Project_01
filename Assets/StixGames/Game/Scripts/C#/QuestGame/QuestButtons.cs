using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestButtons : MonoBehaviour {

	public static bool mission_01;
	public static bool mission_02;

	public GameObject obj_01;
	public GameObject obj_02;

    void Start() {
        mission_01 = true;
    }

	void Update () {
		if (mission_01) {
			obj_01.SetActive (true);
			obj_02.SetActive (false);
		} else {
			obj_01.SetActive (false);
		}

		if (mission_02) {
			obj_01.SetActive (false);
			obj_02.SetActive (true);
		} else {
			obj_02.SetActive (false);
		}
	}

	public void Buttons(int a){
		if(a == 1){
			mission_01 = !mission_01;
			mission_02 = false;
		}else if(a == 2){
			mission_02 = !mission_02;
			mission_01 = false;
		}
	}

}
