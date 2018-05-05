using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuGameplayButtons : MonoBehaviour {

	public GameObject menu_01;
	public GameObject menu_02;
	public GameObject menu_03;
	public GameObject menu_04;

	public static bool active;
	public static bool active2;

	public void Buttons (int a) {
		if(a == 1){
			MenuGameplayActive.menuActive = !MenuGameplayActive.menuActive;
			MenuGameplayActive.time_01 = 0;
		}else if(a == 2){
			
		}else if(a == 3){

		}else if(a == 4){
			menu_01.SetActive (false);
			menu_02.SetActive (true);
			active = true;
		}else if(a == 5){
			
		}else if(a == 6){
			menu_02.SetActive (false);
			menu_03.SetActive (true);
			active2 = true;
		}else if(a == 7){

		}else if(a == 8){
			menu_02.SetActive (false);
			menu_04.SetActive (true);
			active2 = true;
		}else if(a == 9){

		}else if(a == 10){
			menu_01.SetActive (true);
			menu_02.SetActive (false);
			active = false;
		}else if(a == 11){

		}else if(a == 12){

		}else if(a == 13){

		}else if(a == 14){

		}else if(a == 15){
			menu_02.SetActive (true);
			menu_03.SetActive (false);
			active2 = false;
			active = true;
		}else if(a == 16){

		}else if(a == 17){

		}else if(a == 18){

		}else if(a == 19){

		}else if(a == 20){
			menu_02.SetActive (true);
			menu_04.SetActive (false);
			active2 = false;
			active = true;
		}
	}
}
