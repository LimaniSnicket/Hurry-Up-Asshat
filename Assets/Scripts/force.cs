using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class force : MonoBehaviour {

	Vector3 inputVector;
	Rigidbody rb;
	public float gravityStrength = 0.01f;
	public float speed;

	public DialogueManager dialogueCheck;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!dialogueCheck.dialogueActive) {
			float horizontal = Input.GetAxis ("Horizontal");
			float vertical = Input.GetAxis ("Vertical");
			inputVector = transform.right * horizontal + transform.forward * vertical;
		} else {
			inputVector = transform.right * 0f + transform.forward * 0f;
		}
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
