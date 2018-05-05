using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsAudio : MonoBehaviour {
	
	public Slider volumeSlider1;
	public Slider volumeSlider2;
	public Slider volumeSlider3;

	public void VolumeController(){
		//volumeSlider.value = MainAudio.valueAudio;
		MainAudio.valueMaster = volumeSlider1.value;
		MainAudio.valueMusic = volumeSlider2.value;
		MainAudio.valueMusic = volumeSlider3.value;
	}
}
