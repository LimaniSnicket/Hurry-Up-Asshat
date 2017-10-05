using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class myText : MonoBehaviour {

	public score ScoreTracker;


	public Text scoreText;
	// Use this for initialization
	void Start () {
		scoreText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(ScoreTracker.playMode==true && ScoreTracker.brotherFound == false){
			scoreText.text = "Get your stuff and get out the door! Your brother is waiting!";
		} else if(ScoreTracker.playMode == false && ScoreTracker.brotherFound == false){
			scoreText.text = "Meet up with your brother ASAP! He's not very patient, \n" +
				"so hurry up! Press Enter to Start!";
		}
		if(ScoreTracker.brotherFound == true){
			scoreText.text = "You found your brother! He's in a shit mood though.";
			//ScoreTracker.playMode = false;

		}
	}
}
