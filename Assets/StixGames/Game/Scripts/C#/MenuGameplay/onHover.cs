using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class onHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

	public Text newText; 
	public int fontSizeVarNormal;
	public int fontSizeVar;

	public void OnPointerEnter(PointerEventData eventData)
	{
		newText.fontSize = fontSizeVar;
	}
	public void OnPointerExit(PointerEventData eventData)
	{
		newText.fontSize = fontSizeVarNormal;
	}
	
}
