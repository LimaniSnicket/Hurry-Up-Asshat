using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

	public static DialogueManager Instance { get; set;}

	public List<string> dialogueLines = new List<string>();
	public string npcName;

	// UI Stuff goes here
	public GameObject dialoguePanel;
	Button continueButton;
	public Text dialogueText, nameText;
	int dialogueIndex;

	public bool dialogueActive = false;

	// Use this for initialization
	void Awake () {

		dialoguePanel.SetActive (false);

		if (Instance != null && Instance != this) {
			Destroy (gameObject);
		} else {
			Instance = this;
		}
		
	}
	
	public void AddNewDialogue(string[] lines, string npcName){
		dialogueIndex = 0;
		dialogueLines = new List<string> (lines.Length);
		dialogueLines.AddRange (lines);
		foreach (string line in lines) {
			dialogueLines.Add (line);

		}
		this.npcName = npcName;
		CreateDialogue ();

	}
	void Update(){

		if (Input.GetKeyUp (KeyCode.Return)) {
			continueDialogue ();
		}

	
	}

	public void CreateDialogue(){
		dialogueText.text = dialogueLines [dialogueIndex];
		nameText.text = npcName;
		dialoguePanel.SetActive (true);
		dialogueActive = true;
	}

	public void continueDialogue(){

		if (dialogueIndex < dialogueLines.Count - 1) {
				dialogueIndex++;
				dialogueText.text = dialogueLines [dialogueIndex];
			} else {
				dialoguePanel.SetActive (false);
				dialogueActive = false;
			}
		}

}
