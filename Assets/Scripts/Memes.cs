using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Memes : MonoBehaviour {

	public bool found;

	public score playerTracker;
	float range = 5f;
	public bool inRange;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerStay (Collider playerFoundMe){
		if (playerFoundMe.gameObject.tag == "Player" && Input.GetMouseButton(0)) {
			playerTracker.brotherPatience = playerTracker.brotherPatience + 5f;
			Destroy (gameObject);
		} else {
			playerTracker.brotherPatience = playerTracker.brotherPatience - Time.deltaTime *0.5f;
		}
		
	}
}
