using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {
	#region Singleton
	public static Inventory instance;
	void Awake(){
		if(instance != null){
			Debug.LogWarning ("More than one instance found");
			return;
		}
		instance = this;
	}
	#endregion

	public delegate void OnItemChanged ();
	public OnItemChanged OnItemChangedCallback;

	public int maxSize = 20;
	public List<Item> items = new List<Item>();

	public bool Add(Item item){
		
		if(!item.isDefault){
			if (items.Count >= maxSize) {
				Debug.Log ("Inventory Full");
				return false;
			} 
			items.Add (item);
			if(OnItemChangedCallback != null){
				OnItemChangedCallback.Invoke ();
			}
		}
		return true;
	}
	public void Remove(Item item){
		
		items.Remove (item);
		if(OnItemChangedCallback != null){
			OnItemChangedCallback.Invoke ();
		}
	}
}
