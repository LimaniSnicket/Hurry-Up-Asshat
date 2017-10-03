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
		if(playMode == false && Input.GetKey(KeyCode.Return)){
			playMode = true;

		}

		if(playMode){
		gameTimer = gameTimer + Time.deltaTime;
		if(playerScore > 0 && brotherFound == false){
			playerScore = playerScore - Time.deltaTime * 0.5f;
		}
		}

		
	}


	void OnCollisionEnter(Collision objectHittingMe){
		if (objectHittingMe.gameObject.tag == "Anthony") {
			brotherFound = true;
		}


	}

}
