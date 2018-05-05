using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestActive : MonoBehaviour {

	public static bool questActive;

	public GameObject Quest;

	public Animation anim1;
	public Animation anim2;
	public Animation anim3;

	public string animName1;
	public string animName2;
	public string animName3;
	public string animName1close;
	public string animName2close;
	public string animName3close;

	public float time_01;
	public float time_01End;
	public float time_02End;

	public MonoBehaviour script_01;
	public MonoBehaviour script_02;
	public MonoBehaviour script_03;

	public GameObject Canvas;

	void Update () {
		if(Input.GetKeyDown(KeyCode.B) && time_01 >= time_02End && !MenuGameplayActive.menuActive && !InventoryActive.inventoryActive && !Datebase.LoadActive)
        {
			questActive = !questActive;
			time_01 = 0;
		}
		if (questActive) {
			time_01 += Time.deltaTime;
			script_01.enabled = false;
			script_02.enabled = false;
			script_03.enabled = false;
			CrossActive.active = false;
			Canvas.SetActive (false);
			if (time_01 < 0.1f) {
				anim1.Play (animName1);
			}
			if (time_01 > time_01End && time_01 < time_01End + 0.1f) {
				Quest.SetActive (true);
				anim2.Play (animName2);
				anim3.Play (animName3);
				CursorStatic.active = true;
			}
		} else {
			time_01 += Time.deltaTime;
			script_01.enabled = true;
			script_02.enabled = true;
			script_03.enabled = true;
			if (time_01 < 0.1f) {
				anim1.Play (animName1close);
				anim2.Play (animName2close);
				anim3.Play (animName3close);
			}
			if(time_01 > time_01End){
				Quest.SetActive (false);
			}
		}
	}
}
