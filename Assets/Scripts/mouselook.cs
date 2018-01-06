using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouselook : MonoBehaviour {
	float verticalLook = 0f;
	public float mouseSensitivity = 60f;

	public DialogueManager dialogueCheck;

	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {

		float mouseX = Input.GetAxis ("Mouse X");
		float mouseY = Input.GetAxis ("Mouse Y");
		transform.parent.Rotate (0f, mouseX *Time.deltaTime * mouseSensitivity, 0f);
		verticalLook -= mouseY * Time.deltaTime *mouseSensitivity; 
		verticalLook = Mathf.Clamp (verticalLook,-85f,85f); //controls max/min angles player can look at


		//manually override z euler angle to 0
		transform.localEulerAngles = new Vector3(verticalLook,transform.localEulerAngles.y,0f);

		if(!dialogueCheck.dialogueActive){ //if user clicks, lock mouse
			//Cursor.visible = false; //hides mouse cursor
			//Cursor.lockState = CursorLockMode.Locked; //lock cursor to center of window
			Time.timeScale = 1f;

		
		} else { //reveals cursor again when dialogue menu is active
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;
			Time.timeScale = 0f;
		}
	}
}
