using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemTracker : MonoBehaviour {

	//alternative raycast that keeps track of what the player is looking at and translates it to the text script mytext
	public bool loookingAtWallet = false;
	public bool lookingAtBag = false;
	public bool lookingAtKeys = false;
	public bool lookingAtQuest = false;
	public bool lookingAtTickets = false;
	public bool lookingAtMeme = false;
	public bool lookingAtDog = false;
	public bool lookingAtDoor = false;

	void Start(){

	}
	void FixedUpdate(){
		Ray myRay = new Ray(transform.position, transform.right *-1f);

		RaycastHit rayHit = new RaycastHit ();

		//max distance for raycast
		float maxDistance = 5f;

		//optional but recommended, visualize raycast in scene debug
		Debug.DrawRay(myRay.origin, myRay.direction*maxDistance, Color.red);

		//step 4 actually shoot raycast
		if (Physics.Raycast (myRay, out rayHit, maxDistance) && (rayHit.collider.gameObject.tag == "Wallet")) {
			loookingAtWallet = true;
		} else {
			loookingAtWallet = false;
		}
		if (Physics.Raycast (myRay, out rayHit, maxDistance) && (rayHit.collider.gameObject.tag == "Bag")) {
			lookingAtBag = true;
		} else {
			lookingAtBag = false;
		}
		if (Physics.Raycast (myRay, out rayHit, maxDistance) && (rayHit.collider.gameObject.tag == "Food")) {
			lookingAtQuest = true;
		} else {
			lookingAtQuest = false;
		}
		if (Physics.Raycast (myRay, out rayHit, maxDistance) && (rayHit.collider.gameObject.tag == "Key")) {
			lookingAtKeys = true;
		} else {
			lookingAtKeys = false;
		}
		if (Physics.Raycast (myRay, out rayHit, maxDistance) && (rayHit.collider.gameObject.tag == "Tickets")) {
			lookingAtTickets = true;
		} else {
			lookingAtTickets = false;
		}

		if (Physics.Raycast (myRay, out rayHit, maxDistance) && (rayHit.collider.gameObject.tag == "Meme")) {
			lookingAtMeme = true;
		} else {
			lookingAtMeme = false;
	}
		if (Physics.Raycast (myRay, out rayHit, maxDistance) && (rayHit.collider.gameObject.tag == "Dog")) {
			lookingAtDog = true;
		} else {
			lookingAtDog = false;
		}

		if (Physics.Raycast (myRay, out rayHit, maxDistance) && (rayHit.collider.gameObject.tag == "Front Door")) {
			lookingAtDoor = true;
		} else {
			lookingAtDoor = false;
		}
	}



}
