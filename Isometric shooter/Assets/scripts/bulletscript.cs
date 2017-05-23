using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
	public int damage = 25;
	// Use this for initialization
	void Start () {
		Destroy (this.gameObject, 4f);


	}

//	void OnTriggerEnter(Collider other){
//		Debug.Log ("OW");
//
//		if (other.tag == "Player") {
//			other.GetComponent<Player> ().TakenDamage (damage);
//		}
//
//		Destroy (this.gameObject); 
//
//	}
}