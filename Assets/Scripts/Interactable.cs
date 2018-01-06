using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour {

	public bool NPC;
	public string name;

	public string[] dialogue;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void interactWithNPC(){
		if(Input.GetMouseButton(0)) {
			Debug.Log ("Talking to NPC");
			DialogueManager.Instance.AddNewDialogue(dialogue, name);

		}

	}
}
