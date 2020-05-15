using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class displayControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<TextMesh> ().text = keypad.playerInput;	
	}
}
