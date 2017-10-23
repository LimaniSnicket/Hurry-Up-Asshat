using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Messages : MonoBehaviour {

	public float messageTimer = 0f;
	public float displayTimer = 0f;
	public score playerTracker;
	public RaycastGrounded rayTrack;

	bool gotText = false;

	bool dogText;
	bool catText;
	bool memeText;
	public Image textMsg;
	public Sprite[] activeMsg;

	//temp text to make sure it actually works:
	public Text test;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(playerTracker.playMode == true && displayTimer == 0f && gotText == false && messageTimer < 15f){
			messageTimer = messageTimer + Time.deltaTime;
		} 
		if(displayTimer != 0f && gotText == true){
			messageTimer = messageTimer;
		}

		if(gotText == false){
			test.text = "";
			textMsg.sprite = activeMsg [0];
		}
		if(displayTimer > 5f){
			displayTimer = 0f;
			gotText = false;
		}

		if (gotText == true) { //starts timer upon getting a text
			displayTimer = displayTimer + Time.deltaTime;
		} else if (gotText == false) {
			displayTimer = 0f;
		}
		if (displayTimer <= 5f && displayTimer != 0f) { //displays the text for about 5 seconds
			gotText = true;
		} else {
			gotText = false;

		}
		int randomMeme = Random.Range (1, 3);
		int randomDog = Random.Range (4, 6);
		int randomCat = Random.Range (7, 9);
		int randomMsg = Random.Range (10, 16);
		if(rayTrack.meme == true){
			gotText = true;
			test.text = "meme";
			textMsg.sprite = activeMsg [randomMeme];
		} else if(rayTrack.dog == true){
			gotText = true;
			test.text = "dog";
			textMsg.sprite = activeMsg [randomDog];
		} else if (rayTrack.cat == true){
			gotText = true;
			test.text = "cat";
			textMsg.sprite = activeMsg [randomCat];
		}

		if(messageTimer >= 15f && rayTrack.meme == false ||
			messageTimer >= 15f && rayTrack.cat == false ||
			messageTimer >= 15f && rayTrack.dog == false){
			gotText = true;
			test.text = "text from bro";
			textMsg.sprite = activeMsg [randomMsg];
		}
		
	}

}
