using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanRaycast : MonoBehaviour {

	public Interact focus;
	public bool lookingAtItem = false;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update(){

	}
	void FixedUpdate(){
		//step one, declare ray object
		Ray myRay = new Ray (transform.position, transform.forward);
		RaycastHit rayHit = new RaycastHit ();
		//max distance for raycast
		float maxDistance = 2f;
		//optional but recommended, visualize raycast in scene debug
		Debug.DrawRay (myRay.origin, myRay.direction * maxDistance, Color.red);

		//raycast effects here
		if (Physics.Raycast (myRay, out rayHit, maxDistance) && (rayHit.collider.gameObject.tag == "Dog")) {
			Debug.Log ("Raycast hit");
			rayHit.transform.SendMessage ("PlayerFoundMe");
		}
		if (Physics.Raycast (myRay, out rayHit, maxDistance) && (rayHit.collider.gameObject.tag == "NPC")) {
			//Debug.Log ("NPC Found");
			rayHit.transform.SendMessage ("interactWithNPC");
		}


		if(Input.GetMouseButton(0)){
			if (Physics.Raycast (myRay, out rayHit, maxDistance)) {
				lookingAtItem = true;
				Interact interaction = rayHit.collider.GetComponent<Interact> ();
				if (interaction != null) {
					SetFocus (interaction);
				}
			} 
		}
		if(!Physics.Raycast (myRay, out rayHit, maxDistance)){
			RemoveFocus ();
		}
	}

	public void SetFocus(Interact newFocus){
		
		if(newFocus != focus){
			if(focus != null){
				focus.OnDefocused ();
			}
			focus = newFocus;
		}
		newFocus.OnFocus (transform);
	}

	public void RemoveFocus(){
		focus = null;
		lookingAtItem = false;

		if(focus != null){
			focus.OnDefocused ();
			}
		}

}
