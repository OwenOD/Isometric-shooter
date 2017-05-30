using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletscript : MonoBehaviour {
	public int damage = 2;
	// Use this for initialization
	void Start () {
		Destroy (this.gameObject, 4f);


	}

	void OnTriggerEnter(Collider other){
		Debug.Log ("OW");

		if (other.tag == "Enemy") {
			other.GetComponent<Enemy> ().TakenDamage (damage);
		}

		Destroy (this.gameObject); 

	}
}