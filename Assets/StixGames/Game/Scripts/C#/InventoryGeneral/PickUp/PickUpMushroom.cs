using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpMushroom : MonoBehaviour {

	public GameObject item;
	public GameObject text;

	public float distance;

	void Update () {
		Vector3 fwd = transform.TransformDirection(Vector3.forward);
		RaycastHit hit;

		if (Physics.Raycast (transform.position, fwd, out hit)) {

			if (hit.distance <= distance && hit.collider.gameObject.tag == "Mushroom") {
				text.SetActive (true);
				CrossActive.active = false;

				if (Input.GetKeyDown ("e") && !InventoryActive.inventoryActive && !MenuGameplayActive.menuActive) {
					//Destroy (hit.collider.gameObject);
                    hit.collider.gameObject.SetActive(false);

                    MushroomItem.items += 1;
					text.SetActive (false);
					CrossActive.active = true;
				}
			} else {
				text.SetActive (false);
				CrossActive.active = true;
			}
		}
	}
}