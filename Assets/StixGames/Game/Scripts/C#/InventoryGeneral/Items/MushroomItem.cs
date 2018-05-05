using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MushroomItem : MonoBehaviour {

	public static int items;
	public GameObject item;
	public Text itemText;

	void Update () {
		itemText.text = "Mushrooms               "+items.ToString();
		if(items > 0){
			item.SetActive (true);
		}else if(items < 1){
			item.SetActive (false);
		}
	}
}