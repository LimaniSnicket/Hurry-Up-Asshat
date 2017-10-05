using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemTracker : MonoBehaviour {

	public bool itemFound = false;
	public bool playerClose = false;

	public Sprite[] text;
	public SpriteRenderer activeText;

	public Toggle myToggle;



	// Use this for initialization
	void Start () {
		activeText.sprite = text[0];
	}
	
	// Update is called once per frame
	void Update () {

		if (itemFound) {
			myToggle.isOn = true;
		} else {
			myToggle.isOn = false;
		}

		if (playerClose && itemFound == false) {
			activeText.sprite = text [1];
		} else {
			activeText.sprite = text[0];
		}
	}



	void OnCollisionStay (Collision playerFoundItem){

		if (playerFoundItem.gameObject.tag == "Player") {
			playerClose = true;
		} else {
			playerClose = false;
		}

		if(playerFoundItem.gameObject.tag == "Player" && Input.GetKey(KeyCode.Space)){
			itemFound = true;
		}
	}



}
