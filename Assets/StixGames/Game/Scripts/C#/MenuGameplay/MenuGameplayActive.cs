using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuGameplayActive : MonoBehaviour {

	public static bool menuActive;

	public GameObject Menu;

	public Animation BlurAnim_01;
	public Animation MenuAnim_01;
	public Animation MenuAnim_02;

	public string animName_01;
	public string animName_02;
	public string animName_03;
	public string animName_04;
	public string animName_05;
	public string animName_06;


	public static float time_01;
	public float time_01End;

	public MonoBehaviour script_01;
	public MonoBehaviour script_02;
	public MonoBehaviour script_03;

	public GameObject Canvas;

	public GameObject menu_01;
	public GameObject menu_02;
	public GameObject menu_03;
	public GameObject menu_03a;

	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape) && time_01 >= time_01End && !InventoryActive.inventoryActive && !QuestActive.questActive && !MenuGameplayButtons.active && !MenuGameplayButtons.active2 && !Datebase.LoadActive){
			menuActive = !menuActive;
			time_01 = 0;
		}

		if (menuActive) {
			time_01 += Time.deltaTime;
			script_01.enabled = false;
			script_02.enabled = false;
			script_03.enabled = false;
			CrossActive.active = false;
			Canvas.SetActive (false);
			if (time_01 < 0.1f) {
				BlurAnim_01.Play (animName_01);
			}
			if (time_01 > time_01End && time_01 < time_01End+0.1f) {
				Menu.SetActive (true);
				MenuAnim_01.Play (animName_03);
				MenuAnim_02.Play (animName_05);
				CursorStatic.active = true;
			}
		} else {
			time_01 += Time.deltaTime;
			script_01.enabled = true;
			script_02.enabled = true;
			script_03.enabled = true;
			if (time_01 < 0.1f) {
				BlurAnim_01.Play (animName_02);
				MenuAnim_01.Play (animName_04);
				MenuAnim_02.Play (animName_06);
			}
			if(time_01 > time_01End){
				Menu.SetActive (false);
			}
		}
		if(!menuActive && !InventoryActive.inventoryActive && !QuestActive.questActive){
			CursorStatic.active = false;
			//CrossActive.active = true;
			Canvas.SetActive (true);
		}
	}
}
