using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	Ray ray;

	void Update() {
		RaycastHit hit;
		ray = Camera.main.ViewportPointToRay(new Vector3(0.5f,0.5f));

		Debug.DrawRay(ray.origin, ray.direction, Color.white);

		if(Physics.Raycast(ray, out hit, 2f)) {
			switch(hit.transform.tag) {
				case "Interactive":
					if(Input.GetMouseButtonDown(0)) {
						Debug.Log("It is interactive");
						hit.transform.GetComponent<ObjectController>().setActive(true);
					}
					break;
				case "Collectable":
					if(Input.GetMouseButtonDown(0)) {
						//Considering having the prefab. Ex: create a flashlight
						Debug.Log("It is collectable");
						transform.GetComponent<Collection>().collect(hit.transform.name);
						Destroy(hit.transform.gameObject);
					}
					break;
				default:
					if(Input.GetMouseButtonDown(0)) {
						Debug.Log("It is static");
					}
					break;
			}
		}
	}
}
