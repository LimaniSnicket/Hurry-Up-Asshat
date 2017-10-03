using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class score : MonoBehaviour {

	public float gameTimer = 0;
	public float playerScore = 0;

	public bool playMode = false;
	public bool brotherFound = false;

	public bool memeFound;

	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {
		gameTimer = gameTimer + Time.deltaTime;
		if(playerScore > 0 && brotherFound == false){
			playerScore = playerScore - Time.deltaTime * 0.5f;
		}

		if (memeFound == true && Input.GetKey (KeyCode.Space)) {
			Debug.Log ("You sent a zesty meme to your brother");
			memeFound = false;
			playerScore = playerScore + 5;
		} else if(memeFound == false && Input.GetKey(KeyCode.Space)){
			Debug.Log ("Find new memes you normie");
		}
		
	}


	void OnCollisionEnter(Collision objectHittingMe){
		if (objectHittingMe.gameObject.tag == "Anthony") {
			brotherFound = true;
		}


	}

}
