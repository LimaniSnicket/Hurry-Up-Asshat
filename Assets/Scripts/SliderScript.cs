using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour {

	public score ScoreTracker;

	public Slider patienceSlider;

	// Use this for initialization
	void Start () {
		patienceSlider = GetComponent<Slider> ();

	}
	
	// Update is called once per frame
	void Update () {
		patienceSlider.value = ScoreTracker.brotherPatience;
		
		
	}




}
