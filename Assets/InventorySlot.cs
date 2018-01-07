using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventorySlot : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

	Item item;
	public Image icon; 
	public Button removeButton;
	private ToolTip toolTip;
	public InventoryUI inv;



	void Start(){
		toolTip = inv.GetComponent<ToolTip> ();

	}

	public void AddItem(Item newItem){

		item = newItem;
		icon.sprite = item.icon;
		icon.enabled = true;
		removeButton.interactable = true;
		
	}

	public void ClearSlot(){

		item = null;
		icon.sprite = null;
		icon.enabled = false;
		removeButton.interactable = false;

	}

	public void OnRemoveButton(){
		
		Inventory.instance.Remove (item);


	}

	public void UseItem(){
		if(item != null){
			item.Use ();

		}
	}

//	public void StackItem(){
//		stack_num++;
//		stackText.text = (stack_num);
//	}
	public void OnPointerEnter(PointerEventData eventData){
		if (item != null) {
			toolTip.Activate (item);
		}
	}
	public void OnPointerExit(PointerEventData eventData){
		toolTip.Deactivate ();
	}
}
