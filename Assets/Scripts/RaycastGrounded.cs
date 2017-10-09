using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastGrounded : MonoBehaviour {

	public bool isGrounded = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//step one, declare ray object
		Ray myRay = new Ray(transform.position, transform.right *-1f);

		RaycastHit rayHit = new RaycastHit ();

		//max distance for raycast
		float maxDistance = 2f;

		//optional but recommended, visualize raycast in scene debug
		Debug.DrawRay(myRay.origin, myRay.direction*maxDistance, Color.red);

		//step 4 actually shoot raycast
		if (Physics.Raycast (myRay, maxDistance) && (rayHit.collider.gameObject.tag == "Wallet")) {
			Debug.Log ("grounded");
			isGrounded = true;
		} else {
			isGrounded = false;
		}

	}
}
