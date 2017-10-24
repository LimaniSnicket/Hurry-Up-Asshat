using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class force : MonoBehaviour {

	Vector3 inputVector;
	Rigidbody rb;
	public float gravityStrength = 0.01f;
	public float speed;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");
		inputVector = transform.right * horizontal + transform.forward * vertical;

		if(inputVector.magnitude > 1f){
			inputVector = Vector3.Normalize (inputVector);
		}

	}
	void FixedUpdate(){
		//override velocity directly
		//only if not pressing anything 
		if(inputVector.magnitude >0.01f){
			rb.velocity = inputVector * speed + Physics.gravity * gravityStrength;
		}
	}
}
