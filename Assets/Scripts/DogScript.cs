using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DogScript : MonoBehaviour {
	
	public string dogName;
	public string description;
	public GameObject dogButton;
	public GameObject menuPanel;

	public GameObject dogHitBox;
	
	public enum DogType{
	Husky,
	Shiba,
	Corgi,
	Lab,
	Sailor,
	Dalmation,
	Poodle,
	Dach,
	Pug,
	Rottweiler,
	Pyranese,
	}
		
	public DogType thisDog;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//test instantiating buttons

			
		}
		

	void PlayerFoundMe(){

		if(Input.GetMouseButton(0)){
			GameObject newButton = Instantiate(dogButton) as GameObject;
			newButton.transform.SetParent(menuPanel.transform, false);
			Destroy (dogHitBox);
		
		}
	}
}
