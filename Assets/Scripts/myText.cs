using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class myText : MonoBehaviour {

	public score ScoreTracker;
	public bool collisionText;
	public ItemTracker itemText;


	public Text scoreText;
	// Use this for initialization
	void Start () {
		scoreText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {


		if (ScoreTracker.playMode == true && ScoreTracker.brotherFound == false && itemText.lookingAtBro == false) {
			if (itemText.loookingAtWallet == true) {
				scoreText.text = "Grab your wallet!";
			} else if (itemText.lookingAtBag == true) {
				scoreText.text = "Grab your bag!";
			} else if (itemText.lookingAtTickets == true) {
				scoreText.text = "Grab the Epica tickets!";
			} else if (itemText.lookingAtKeys == true) {
				scoreText.text = "Grab your keys, otherwise Dad'll flip his shit at you!";
			} else if (itemText.lookingAtQuest == true) {
				scoreText.text = "Grab your Quest Bar! You need your protein";
			} else if (itemText.lookingAtDog == true) {
				scoreText.text = "HOLY SHIT DOG! SEND IT TO YOUR BROTHER!";
			} else if (itemText.lookingAtMeme == true) {
				scoreText.text = "Ayy lmao 69, your bro would find this funny";
			} else if (itemText.lookingAtDoor == true && ScoreTracker.lockedOut == false) {
				scoreText.text = "Left Click to go through the doorway";
			} else if (itemText.lookingAtDoor == true && ScoreTracker.lockedOut == true) {
				scoreText.text = "You left your keys inside and locked yourself out, you dumbass";
			} else if (itemText.lookingAtCat == true) {
				scoreText.text = "LOOK AT THAT RAD CAT! SEND IT TO YOUR BROTHER!";
			} else {
				scoreText.text = "Your brother's running out of patience! Grab your stuff and go meet up with him before he leaves";
			}
		} else {
			scoreText.text = "Meet up with your brother ASAP! He's not very patient, so hurry up! Right Click to Start/Pause! Left Click to interact with objects";
		}

		if(ScoreTracker.brotherFound == false && itemText.lookingAtBro == true){
			scoreText.text = "Yo, your bro is over there! Hurry up";
		} else if(ScoreTracker.win == true){
			scoreText.text = "You found your brother! Now you can go get crushed at that concert";
		} else if (ScoreTracker.lose == true){
			scoreText.text = "You took too long, your brother got pissed off and left without you!";
		}





	}
}
