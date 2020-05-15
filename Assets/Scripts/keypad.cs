using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keypad : MonoBehaviour {

	public static string code = "8325";
	public static string playerInput = "";
	public static int totalDigits = 0;


    // Use this for initialization
    void Start () {


    }
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (playerInput);

		if (totalDigits == 4) {
			
			if (playerInput == code) {
				Debug.Log ("Correct");
				playerInput = "";
				totalDigits = 0;
                EventManager.KeyPadCorrect = true;
                

            } else {
				totalDigits = 0;
				Debug.Log ("not correct");
				playerInput = "";

			}
		}
	}

	void OnMouseUp(){
		playerInput += gameObject.name;
		totalDigits++;
		Debug.Log (playerInput);
	}


	void OnMouserOver(){

		//GetComponent<MeshRenderer> ().material.color = new Color (0, 1, 0);

	}


	void OnMouserExit(){
		//GetComponent<MeshRenderer> ().material.color = new Color (1, 1, 1);
	}


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "LeftHandAnchor" || other.gameObject.name == "RightHandAnchor")
        {
            playerInput += gameObject.name;
            totalDigits++;

            this.GetComponent<AudioSource>().Play();
            Debug.Log(playerInput);
        }
    }
}
