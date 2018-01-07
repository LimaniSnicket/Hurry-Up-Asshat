using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToolTip : MonoBehaviour {

	Item item;
	private string data;

	private GameObject toolTip;

	void Start(){
		toolTip = GameObject.Find ("Tool Tip");
		toolTip.SetActive (false);
	}

	void Update(){
		if(toolTip.activeSelf){
			toolTip.transform.position = Input.mousePosition;

		}
	}

	public void Activate(Item item){
		this.item = item;
		toolTip.SetActive (true);
		ConstructString ();
	}

	public void Deactivate(){
		toolTip.SetActive (false);
	}

	public void ConstructString(){

		data = item.item_name + "\n" + item.item_description;
		toolTip.transform.GetChild (0).GetComponent<Text>().text = data;

	}
}
