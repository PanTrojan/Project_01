using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralActivity : MonoBehaviour {
	
	public GameObject CanvasQuest;

	//Quest
	public GameObject mission_01;
    public GameObject mission_02;


    void Update () {
		if (MenuGameplayActive.menuActive || InventoryActive.inventoryActive || QuestActive.questActive) {
			CanvasQuest.SetActive (false);
            mission_01.SetActive(false);
            mission_02.SetActive(false);
		} else {
			CanvasQuest.SetActive (true);
		}
	}
}
