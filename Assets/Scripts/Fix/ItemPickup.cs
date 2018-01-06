using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : Interact {

	public Item item;

	public override void Interacting(){
		
		base.Interacting ();

		PickUp ();
	}

	public void PickUp(){

		Debug.Log ("Picking Up " + item.item_name);
		bool wasPickedUp = Inventory.instance.Add (item);
		if (wasPickedUp) {
			Destroy (gameObject);
		}
	}
}
