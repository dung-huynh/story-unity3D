using UnityEngine;
using System.Collections;

public abstract class ObjectController : MonoBehaviour {

	public bool isActive;
	public bool active {
		get {
			return isActive;
		}
		set {
			isActive = value;
		}
	}

	public abstract void setActive(bool condition);
}