using UnityEngine;
using System.Collections;

public class DoorController : ObjectController {

	float currentYRot;			//Change dynamically
	bool isOpen;

	float MIN_ANGLE;			//Initial angle
	float MAX_ANGLE;			//Maximum angle
	float time;
	static float speed = 0.68f;	//is 40 if not using sine
	static int angle = 93;

	void Start() {
		isOpen = false;
		currentYRot = transform.parent.transform.eulerAngles.y;
		MIN_ANGLE = transform.parent.transform.eulerAngles.y;
		MAX_ANGLE = currentYRot + angle;

		//Debug.Log("Max: " + MAX_ANGLE);
		//Debug.Log("Min: " + MIN_ANGLE);
	}

	void Update() {
		if(active == true) {
			time += Time.deltaTime;
			//Debug.Log("Timer: " + time);

			if(isOpen == false) {
				//Debug.Log("the door was closed");
				//Debug.Log("Y: " + Mathf.Ceil(currentYRot));
				//Debug.Log(Mathf.Ceil(currentYRot) + " < " + MAX_ANGLE + ": " + (Mathf.Ceil(currentYRot) < MAX_ANGLE));

				//if(Mathf.Ceil(currentYRot) < MAX_ANGLE) {
				if(time < 2.45) {
					currentYRot = MIN_ANGLE + Mathf.Sin(time*speed)*angle;
				}
				else {
					reset();
				}
			}
			else {
				//Debug.Log("the door was open");
				//if(Mathf.Floor(currentYRot) > MIN_ANGLE) {
				if(time < 2.45) {
					currentYRot = MAX_ANGLE - Mathf.Sin(time*speed)*angle;
				}
				else {
					reset();
				}
			}
			transform.parent.transform.eulerAngles = new Vector3(transform.parent.transform.eulerAngles.x, currentYRot, transform.parent.transform.eulerAngles.z);
		}
	}

	void reset() {
		active = false;
		time = 0;
		isOpen = !isOpen;
	}

	public override void setActive(bool condition) {
		active = condition;
	}
}