using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuGameplayTogle : MonoBehaviour {

	public Toggle toggleUI_01;
	public MonoBehaviour script_01;

	public Toggle toggleUI_02;
	public MonoBehaviour script_02;

    public Toggle toggleUI_03;
    public MonoBehaviour script_03;

    public void Togle (int a) {
		if (a == 1) {
			if (toggleUI_01.isOn) {
				script_01.enabled = true;
			} else {
				script_01.enabled = false;
			}
		} else if (a == 2) {
			if (toggleUI_02.isOn) {
				script_02.enabled = true;
			} else {
				script_02.enabled = false;
			}
		}
        else if (a == 3)
        {
            if (toggleUI_03.isOn)
            {
                script_03.enabled = true;
            }
            else
            {
                script_03.enabled = false;
            }
        }
    }
}
