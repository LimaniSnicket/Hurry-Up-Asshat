using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Messages : MonoBehaviour {

	public float messageTimer = 0f;
	public float displayTimer = 0f;
	public score playerTracker;
	public RaycastGrounded rayTrack;
	public ItemTracker itemTrack;

	public bool gotText = false;

	public Image textMsg;
	public Sprite[] activeMsg;

	public Image notifIcon;
	public Sprite[] currentNotif;

	public AudioSource vibrationSource;
	public AudioClip vibrate;

	//temp text to make sure it actually works:
	public Text test;


	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {

		if(gotText == false){
			//test.text = "";
			textMsg.sprite = activeMsg [0];
			notifIcon.sprite = currentNotif [0];

		}


		if(displayTimer > 3f){
			displayTimer = 0f;
			gotText = false;
		}

		if (gotText == true) { //starts timer upon getting a text
			displayTimer = displayTimer + Time.deltaTime;
			notifIcon.sprite = currentNotif [1];
		} 
		if (displayTimer <= 3f && displayTimer != 0f) { //displays the text for about 3 seconds
			gotText = true;
		} 


		int randomMeme = Random.Range (1, 3);
		int randomDog = Random.Range (4, 6);
		int randomCat = Random.Range (7, 9);
		int randomMsg = Random.Range (10, 16);
		if (itemTrack.lookingAtMeme == true && Input.GetMouseButton(0)) {
			gotText = true;
			//test.text = "meme";
			textMsg.sprite = activeMsg [randomMeme];
			vibrationSource.PlayOneShot (vibrate);
		} else if (itemTrack.lookingAtDog == true && Input.GetMouseButton(0)) {
			gotText = true;
			//test.text = "dog";
			textMsg.sprite = activeMsg [randomDog];
			vibrationSource.PlayOneShot (vibrate);
		} else if (itemTrack.lookingAtCat == true && Input.GetMouseButton(0)) {
			gotText = true;
			//test.text = "cat";
			textMsg.sprite = activeMsg [randomCat];
			vibrationSource.PlayOneShot (vibrate);
		} 




	}

}

