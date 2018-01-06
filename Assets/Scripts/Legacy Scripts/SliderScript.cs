using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour {

	public score ScoreTracker;

	public Slider patienceSlider;
	public Image brotherSprite;
	public Sprite passive;
	public Sprite angery;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		patienceSlider.value = ScoreTracker.brotherPatience;

		if(ScoreTracker.brotherPatience >= 40f){
			brotherSprite.sprite = passive;
		} else {
			brotherSprite.sprite = angery;

		}

		
		
	}




}
