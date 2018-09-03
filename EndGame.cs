using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour {
	public Text LoseText;
	void start(){
		LoseText.text ="";
	}

	
	void OnTriggerEnter(Collider other){
		Destroy(other.gameObject);
		LoseText.text = "You Lose";
	}
}
