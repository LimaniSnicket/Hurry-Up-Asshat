using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour {

	public CleanRaycast playerRay;

	bool isFocus = false;
	public Transform player;

	public Transform interactionTransform;

	bool hasInteracted = false;

	public virtual void Interacting(){
		//this method is meant to be overwritten
		Debug.Log ("Interact with " + transform.name);

	}

	void Start(){
		if(interactionTransform == null){
			interactionTransform = transform;
		}
	}

	
	// Update is called once per frame
	void Update () {

		if(isFocus && !hasInteracted){
			if(playerRay.lookingAtItem){

				Interacting ();
				hasInteracted = true;
			}
		}
		
	}

	public void OnFocus(Transform playerTransform){
		isFocus = true;
		player = playerTransform;
		hasInteracted = false;
	}
	public void OnDefocused(){
		isFocus = false;
		player = null;
		hasInteracted = false;
	}
}
