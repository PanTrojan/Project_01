using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestCurrent : MonoBehaviour {

	public static bool mission_01;
	public static bool mission_02;

	public GameObject obj_01;
	public GameObject obj_02;

	void Start(){
		mission_01 = true;
	}

	void Update () {
		//MisionsUI
		if (mission_01) {
			obj_01.SetActive (true);
		} else {
			obj_01.SetActive (false);
            QuestButtons.mission_01 = false;
        }

		if(mission_02){
			obj_02.SetActive (true);
        } else {
			obj_02.SetActive (false);
            QuestButtons.mission_02 = false;
        }
	}
}