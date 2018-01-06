using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitByRay : MonoBehaviour {

	public GameObject FoundParticle;
	public GameObject HoverTrue;
	public bool animal;
	public AudioSource itemSound;
	public AudioClip soundMade;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void RayHitMe(){
		Vector3 currentPos = transform.position;

		if(animal == false){
		GameObject hoverObj = Instantiate (HoverTrue) as GameObject;
		Vector3 hoverObjPos = hoverObj.transform.position;
		hoverObjPos.x = currentPos.x;
		hoverObjPos.y = currentPos.y;
		hoverObjPos.z = currentPos.z;
		hoverObj.transform.position = hoverObjPos;

		if(Input.GetMouseButton(0)){
		GameObject newObject = Instantiate (FoundParticle) as GameObject;
		Vector3 newObjPos = newObject.transform.position;
		newObjPos.x = currentPos.x;
		newObjPos.y = currentPos.y;
		newObjPos.z = currentPos.z;
		newObject.transform.position = newObjPos;
		}
		}
		transform.position = currentPos;

		if(animal == true && Input.GetMouseButtonDown(0)){
			itemSound.PlayOneShot (soundMade);
		}
	}
}
