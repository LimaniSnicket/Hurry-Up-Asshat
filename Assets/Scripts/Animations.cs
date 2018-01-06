using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour {

	public bool dog;
	public bool cat;

	public ItemTracker looking;
	public RaycastGrounded clickedOn;

	public Animator animalAnim;

	// Use this for initialization
	void Start () {

		animalAnim = GetComponent<Animator> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (looking.lookingAtDog == true && dog == true) {
			animalAnim.SetBool ("LookingAtDog", true);
		} else {
			animalAnim.SetBool ("LookingAtDog", false);
		}
		if (dog == true && clickedOn.dog == true) {
			animalAnim.SetBool ("DogFound", true);
		}
	}
}
