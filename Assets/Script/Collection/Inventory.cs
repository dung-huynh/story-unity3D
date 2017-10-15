using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour {

	List<string> items = new List<string>();

	public void addItem(string itemName) {
		items.Add(itemName);
	}
}
