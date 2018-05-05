using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySystem : MonoBehaviour {

	float time;
	public float timeEnd;

	void Update () {
		time += Time.deltaTime;
		if(time >= timeEnd){
            gameObject.SetActive(false);
		}
	}
}
