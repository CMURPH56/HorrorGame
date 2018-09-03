using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour {

	public int speed;
	public GameObject player;
	
	// Update is called once per frame
	void Update () {
		EnemyLook();
		EnemyMove();
	}

	void EnemyLook(){
		transform.LookAt(transform.position + player.transform.rotation * Vector3.left, player.transform.rotation * Vector3.up);
	}


	void EnemyMove(){
		Vector3 localPosition = player.transform.position - transform.position;
		localPosition  = localPosition.normalized;
		transform.Translate(localPosition.x * Time.deltaTime * speed, localPosition.y * Time.deltaTime * speed, localPosition.z * Time.deltaTime * speed );
	}
}
