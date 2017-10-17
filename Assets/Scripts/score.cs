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
	bool inside = true;
	public bool lockedOut = false;

	public bool win = false;
	public bool lose = false;


	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {
		if(playMode==false){
			Time.timeScale = 0.0f;
		} 
		if(playMode == false && Input.GetMouseButtonDown(1)){ //pauses game when right mouse button clicked
			playMode = true;
			Time.timeScale = 1.0f;

		}


		if(playMode){
			if(brotherPatience >0f && brotherFound == false){
				brotherPatience = brotherPatience - Time.deltaTime * 0.5f;
			} else if (brotherPatience >100f){
				brotherPatience = 100f;
			}

			if(brotherPatience <= 0f && brotherFound == false){
				lose = true;
				playMode = false;
			}
		}
		Vector3 currentPos = transform.position; //getting the player in/out past the door collider
		if (rayTrack.door == true && inside == true && Input.GetMouseButton (0)) {
			currentPos.x = frontDoorExit.transform.position.x;
			currentPos.z = frontDoorExit.transform.position.z;
			inside = false;
		} else if (rayTrack.door == true && inside == false && Input.GetMouseButton (0) && rayTrack.key == true) {
			currentPos.x = frontDoorEnter.transform.position.x;
			currentPos.z = frontDoorEnter.transform.position.z;
			inside = true;
		} else if (rayTrack.door == true && inside == false && Input.GetMouseButton(0) && rayTrack.key == false){ //prevents player from
			//entering home again if they forget to take thier keys before they leave
			inside = false;
			lockedOut = true;
		}

		transform.position = currentPos;
	}


	void OnCollisionEnter(Collision objectHittingMe){
		if (objectHittingMe.gameObject.tag == "Anthony" && brotherPatience > 0f) {
			brotherFound = true;
			playMode = false;
			win = true;
		}


	}


}
