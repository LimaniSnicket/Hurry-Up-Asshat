using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour {


	public GameObject inventoryCanvas;
	Inventory inventory;
	InventorySlot[] slots;

	public bool inventoryActive = false;

	public Transform itemParent;


	// Use this for initialization
	void Start () {
		inventory = Inventory.instance;
		inventory.OnItemChangedCallback += UpdateUI;

		slots = itemParent.GetComponentsInChildren<InventorySlot> ();
		
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetButtonDown("Inventory")){
			inventoryCanvas.SetActive (!inventoryCanvas.activeSelf);
		}

		if (inventoryCanvas.activeInHierarchy) {
			inventoryActive = true;
		} else {
			inventoryActive = false;
		}
	}

	void UpdateUI(){
		Debug.Log ("Updating UI");

		for (int i = 0; i < slots.Length; i++){

			if(i < inventory.items.Count){
				slots[i].AddItem(inventory.items[i]);
					
			} else {
						slots[i].ClearSlot();
					}

		}


	}
}
