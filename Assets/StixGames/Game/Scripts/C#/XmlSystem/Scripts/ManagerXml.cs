using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Xml;

public class ManagerXml : MonoBehaviour {

	//public GameObject txtScene;

	public string xmlName;

	public GameObject option_01;
	public GameObject option_02;
	public GameObject option_03;
	public GameObject option_04;
	public GameObject option_05;
	public GameObject option_06;
	public GameObject option_07;
	public GameObject option_08;
	public GameObject option_09;
	public GameObject option_10;
	public GameObject option_11;
	public GameObject option_12;
	public GameObject option_13;
	public GameObject option_14;
	public GameObject option_15;
	public GameObject option_16;
	public GameObject option_17;
	public GameObject option_18;
	public GameObject option_19;
	public GameObject option_20;
	public GameObject option_21;
	public GameObject option_22;
	public GameObject option_23;
	public GameObject option_24;
	public GameObject option_25;
	public GameObject option_26;
	public GameObject option_27;
	public GameObject option_28;
	public GameObject option_29;
	public GameObject option_30;
	public GameObject option_31;
	public GameObject option_32;
	public GameObject option_33;
	public GameObject option_34;
	public GameObject option_35;
	public GameObject option_36;
	public GameObject option_37;
	public GameObject option_38;
	public GameObject option_39;
	public GameObject option_40;

	GameObject[] textOptions;

	private static Dictionary<string, List<string>> optionsByScenes;

	void Start () {
		textOptions = new GameObject[] { option_01, option_02, option_03, option_04, option_05, option_06, option_07, option_08, option_09, option_10, option_11, option_12, option_13, option_14, option_15, option_16, option_17, option_18, option_19, option_20, option_21, option_22, option_23, option_24, option_25, option_26, option_27, option_28, option_29, option_30, option_31, option_32, option_33, option_34, option_35, option_36, option_37, option_38, option_39, option_40 };
		LoadSceneData ();
		PopulateText ();
	}
	
	// Update is called once per frame
	private void LoadSceneData () {
		optionsByScenes = new Dictionary<string, List<string>> ();

		TextAsset xmlData = (TextAsset)Resources.Load (xmlName);
		XmlDocument xmlDocument = new XmlDocument ();
		xmlDocument.LoadXml (xmlData.text);

		foreach (XmlNode scene in xmlDocument["scenes"].ChildNodes){
			string sceneName = scene.Attributes ["name"].Value;

			List<string> options = new List<string>();
			foreach(XmlNode option in scene["options"].ChildNodes){
				options.Add (option.InnerText);
			}
			optionsByScenes [sceneName] = options;
		}
	}

	private void PopulateText(){
		foreach(KeyValuePair<string, List<string>> optionsByScene in optionsByScenes){
		//	txtScene.GetComponent<Text> ().text = optionsByScene.Key;
			for(int i = 0; i < textOptions.Length; i++){
				textOptions[i].GetComponent<Text>().text = optionsByScene.Value[i];
			}
		}
	}

}
