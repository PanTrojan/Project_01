using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryDescription : MonoBehaviour {
	
	public bool desc_01;
	public bool desc_02;

	public GameObject obj_01;
	public GameObject obj_02;

	public GameObject inventory_items;

	void Update () {
		if (desc_01) {
			obj_01.SetActive (true);
			obj_02.SetActive (false);

			inventory_items.SetActive (false);
		} else {
			obj_01.SetActive (false);
		}

		if (desc_02) {
			obj_01.SetActive (false);
			obj_02.SetActive (true);

			inventory_items.SetActive (false);
		} else {
			obj_02.SetActive (false);
		}

		if(!desc_01 && !desc_02){
			inventory_items.SetActive (true);
		}

	}

	public void Buttons(int a){
		if(a == 1){
			desc_01 = false;
			desc_02 = false;
		}else if(a == 2){
			desc_01 = !desc_01;
			desc_02 = false;
		}else if(a == 3){
			desc_02 = !desc_02;
			desc_01 = false;
		}
	}
}
