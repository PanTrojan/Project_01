using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class onHover2 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

	public Text newText; 

	public Color fontColorVarNormal;
	public Color fontColorVar;

	public void OnPointerEnter(PointerEventData eventData)
	{
		newText.color = fontColorVar;
	}
	public void OnPointerExit(PointerEventData eventData)
	{
		newText.color = fontColorVarNormal;
	}
}