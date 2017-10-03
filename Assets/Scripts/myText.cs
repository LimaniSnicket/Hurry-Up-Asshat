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
		if(ScoreTracker.playMode==true){
		scoreText.text = "Score: " + ScoreTracker.playerScore;
		} else if(ScoreTracker.playMode == false){
			scoreText.text = "Meet up with your brother ASAP! Send him some memes too though. Press Enter to Start!";
		}
	}
}
