using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestControl : MonoBehaviour {

	public GameObject obj_01;
	public GameObject obj_02;

	public float time_01;
	public float time_01End;

	void Update () {
		time_01 += Time.deltaTime;
		if(time_01 >= time_01End && time_01 < time_01End+0.1f){
			obj_01.SetActive (true);
		}

        if (MushroomItem.items >= 4 && QuestCurrent.mission_01) {
            QuestCurrent.mission_01 = false;
            QuestCurrent.mission_02 = true;
            obj_02.SetActive(true);
        }

	}
}
