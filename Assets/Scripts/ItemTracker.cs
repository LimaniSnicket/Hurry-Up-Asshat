using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemTracker : MonoBehaviour {

	public bool itemFound = false;
	public bool playerClose = false;

	public Sprite[] text;
	public SpriteRenderer activeText; //shows a pick up icon when player is near an item they need/should get

	public Toggle myToggle;



	// Use this for initialization
	void Start () {
		activeText.sprite = text[0];
	}
	
	// Update is called once per frame
	void Update () {

		if (itemFound) { //checks off missing item in inventory checklist
			myToggle.isOn = true;
		} else {
			myToggle.isOn = false;
		}
		//note to self: get raycasting for items in this bitch
		if (playerClose && itemFound == false) {
			activeText.sprite = text [1];
		} else {
			activeText.sprite = text[0];
		}
	}



	void OnCollisionStay (Collision playerFoundItem){

//		if (playerFoundItem.gameObject.tag == "Player") {
//			playerClose = true;
//		} else {
//			playerClose = false;
//		}

		if(playerFoundItem.gameObject.tag == "Player" && Input.GetMouseButton(0)){
			itemFound = true;
		}
	}
	void OnCollisionExit (Collision testStuff){
		if (testStuff.gameObject.tag == "Player") {
			playerClose = true;
		} else {
			playerClose = false;
		}
	}



}
