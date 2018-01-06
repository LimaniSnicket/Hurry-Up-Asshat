using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour {

	public float brotherPatience = 100f;

	public bool playMode = false;
	public bool brotherFound = false;
	public RaycastGrounded rayTrack;
	public GameObject frontDoorExit;
	public GameObject frontDoorEnter;
	public GameObject indoorStairs;
	public GameObject outdoorStairs;
	bool inside = true;
	public bool lockedOut = false;

	public CanvasGroup myCanvas;
	public Text scoreText;

	public bool win = false;
	public bool lose = false;

	public AudioSource doorSounds;
	public AudioClip locked;
	public AudioClip unlocked;

	public int myScore = 0; 


	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		if(playMode==false){
			Time.timeScale = 0.0f;
		} 
		if(playMode == false && Input.GetMouseButtonDown(1) && win == false){ //pauses game when right mouse button clicked
			playMode = true;
			Time.timeScale = 1.0f;

		}
		scoreText.text = "Score: " + (myScore);




		if(brotherPatience <=20f){
			myScore = myScore + 0;
		}  
		if(brotherPatience <= 40f && brotherPatience > 20f && playMode == true && rayTrack.brother == true){
			myScore = myScore + 20;
		} 
		if (brotherPatience <= 60f && brotherPatience > 40f && playMode == true && rayTrack.brother == true){
			myScore = myScore + 40;
		} 
		if(brotherPatience <=80f && brotherPatience > 60f && playMode == true && rayTrack.brother == true){
			myScore = myScore + 60;
		} 
		if(brotherPatience > 80f && playMode == false && rayTrack.brother == true){
			myScore = myScore + 80;
		}

		if (rayTrack.brother == true) {
			win = true;
			playMode = false;
			brotherFound = true;
		} 


		if(playMode){
			if(brotherPatience >0f && brotherFound == false){
				brotherPatience = brotherPatience - (Time.deltaTime * 0.2f);
			} else if (brotherPatience >100f){
				brotherPatience = 100f;
			}

			if(brotherPatience <= 0f && brotherFound == false){
				lose = true;
				playMode = false;
				myScore = 0;
			}
		}
		Vector3 currentPos = transform.position; //getting the player in/out past the door collider
		if (rayTrack.door == true && inside == true && Input.GetMouseButton (0)) {
			currentPos.x = frontDoorExit.transform.position.x;
			currentPos.z = frontDoorExit.transform.position.z;
			inside = false;
			doorSounds.PlayOneShot (unlocked);
		} else if (rayTrack.door == true && inside == false && Input.GetMouseButton (0) && rayTrack.key == true) {
			currentPos.x = frontDoorEnter.transform.position.x;
			currentPos.z = frontDoorEnter.transform.position.z;
			inside = true;
			doorSounds.PlayOneShot (unlocked);
		} else if (rayTrack.door == true && inside == false && Input.GetMouseButtonDown(0) && rayTrack.key == false){ //prevents player from
			//entering home again if they forget to take thier keys before they leave
			inside = false;
			lockedOut = true;
			doorSounds.PlayOneShot (locked);
		}

		if (rayTrack.stair == true && inside == true && Input.GetMouseButton(0)){
			currentPos.x = indoorStairs.transform.position.x;
			currentPos.y = indoorStairs.transform.position.y;
			currentPos.z = indoorStairs.transform.position.z;
		} else if (rayTrack.stair == true && inside == false && Input.GetMouseButton(0)){
			currentPos.x = outdoorStairs.transform.position.x;
			currentPos.y = outdoorStairs.transform.position.y;
			currentPos.z = outdoorStairs.transform.position.z;
		}

		transform.position = currentPos;
	}




}
