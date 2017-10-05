using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class score : MonoBehaviour {

	public float brotherPatience = 100f;

	public bool playMode = false;
	public bool brotherFound = false;

	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {
		if(playMode==false){
			Time.timeScale = 0.0f;
		} 
		if(playMode == false && Input.GetKey(KeyCode.Return)){
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

}
