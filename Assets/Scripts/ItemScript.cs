using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour {

	public GameObject slotPrefab;
	public GameObject imageSprite;
	public Transform inventoryPanel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void ItemInSight(){
		if(Input.GetMouseButton(0)){
			GameObject newButton = Instantiate(slotPrefab) as GameObject;
			newButton.transform.SetParent(inventoryPanel.transform, false);
			GameObject newSprite = Instantiate (imageSprite) as GameObject;
			newSprite.transform.SetParent (slotPrefab.transform, false);
			Destroy (gameObject);

		}

	}
}
