using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject {

	public enum Type { Default, Sell, Quest }
	public Type thisItem;
	public string item_name = "New Item";
	public string item_description;
	public Sprite icon = null;
	public virtual void Use(){
		//Use The Item

		Debug.Log ("Using " + item_name);
	}

}
