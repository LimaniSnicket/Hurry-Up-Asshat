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

		if(collisionText == false){
			if (ScoreTracker.playMode == false && ScoreTracker.brotherFound == false) {
			scoreText.text = "Meet up with your brother ASAP! He's not very patient, \n" +
			"so hurry up! Right Click to Start/Pause! Left Click to interact with objects";
			} else if(ScoreTracker.brotherFound == true){
			scoreText.text = "You found your brother! He's in a shit mood though.";
	    	 }else {
			scoreText.text = "Get your stuff and get out the door! Your brother is waiting!";
		}

		}
		if (collisionText == true) {
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
			} else if(itemText.lookingAtDog == true){
				scoreText.text = "HOLY SHIT DOG! SEND IT TO YOUR BROTHER!";
			} else if(itemText.lookingAtMeme == true){
				scoreText.text = "Ayy lmao 69, your bro would find this funny";
		    } else {
				scoreText.text = "Don't forget anything!";
			}
		}





	}
}
