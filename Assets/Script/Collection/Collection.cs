/*	-------------------------
 * 	|Items: 				|
 * 	|	Phone				|
 * 	|	Flashlight			|
 * 	|	Breads				|
 * 	|	Cup: to drink water |
 * 	-------------------------
*/

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Collection : MonoBehaviour {

	List<string> items = new List<string>();

	public void collect(string itemName) {
		items.Add(itemName);
	}

	public bool find(string target) {
		if(items.Count > 0)	{
			foreach(string item in items) {
				if(string.Equals(target,item)) { 
					Debug.Log(target + " is found");
					return true;
				}
				else {
					Debug.Log(target + " is not found");
				}
			}
		}
		else {
			Debug.Log("There is no item");
		}
		return false;
	}
}
