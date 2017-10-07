using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour {

	public float brotherPatience = 100f;

	public bool playMode = false;
	public bool brotherFound = false;
	public GameObject frontDoorExit;
	public GameObject frontDoorEnter;

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
		}



		
	}


	void OnCollisionEnter(Collision objectHittingMe){
		if (objectHittingMe.gameObject.tag == "Anthony") {
			brotherFound = true;
		}


	}
	void OnTriggerStay(Collider triggerInteraction){ //moving in and out of front door
		Vector3 currentPos = transform.position;
		if (triggerInteraction.gameObject.tag == "Front Door exit" && Input.GetMouseButton (0)) { //this works
			currentPos.x = frontDoorEnter.transform.position.x;
			currentPos.z = frontDoorEnter.transform.position.z;
		}  
		if (triggerInteraction.gameObject.tag == "Front Door Enter" && Input.GetMouseButtonDown (0)) { //this doesn't work but I'll come back to it later
			currentPos.x = frontDoorExit.transform.position.x;
			currentPos.z = frontDoorExit.transform.position.z;
		}

		transform.position = currentPos;
	}

}
