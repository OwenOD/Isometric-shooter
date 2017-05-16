using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletscript : MonoBehaviour {

	public int life;

	// Use this for initialization
	void Start () {
		Destroy (this.gameObject, life);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
