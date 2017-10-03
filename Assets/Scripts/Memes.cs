using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Memes : MonoBehaviour {

	public bool found;

	public score playerTracker;
	float range = 1f;
	public bool inRange;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 memePos = transform.position;
		Vector3 playerPos = playerTracker.transform.position;
		Vector3 distanceToMeme = (playerPos - memePos);

		if(Mathf.Abs(distanceToMeme.x) >range && Mathf.Abs(distanceToMeme.z) >range){
			inRange = false;
		} else if (Mathf.Abs(distanceToMeme.x) <range && Mathf.Abs(distanceToMeme.z) <range){
			inRange = true;
		}
			

		if (inRange== true && found == false){
			playerTracker.memeFound = true;
		} else if (inRange == false) {
			playerTracker.memeFound = false;
		} else if(inRange == true && found == true){
			playerTracker.memeFound = false;
		}

		if(inRange == true && found == false && Input.GetKey(KeyCode.Space)){
			found = true;
		}


		transform.position = memePos;
		playerTracker.transform.position = playerPos;
	}

	void OnCollisionEnter (Collision playerFoundMe){
		
	}
}
