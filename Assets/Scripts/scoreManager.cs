using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour {
	public DialogueManager dialogueCheck;

	public Slider patienceSlider;

	public float brotherPatience = 300f;
	public int playerScore = 0;
	public bool brotherFound = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		patienceSlider.value = brotherPatience;

		if(brotherPatience >0f && !dialogueCheck.dialogueActive){
			brotherPatience = brotherPatience - (Time.deltaTime * 0.1f);
		} else if (brotherPatience >300f){
			brotherPatience = 300f;
		}else if(brotherPatience == 0f){
			playerScore = 0;
		}
	}
}
