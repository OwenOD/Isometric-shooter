using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

	public Text scoreText;

	private int count;

	void Start () {
//		SetCountText ();
//		count = 0;
	}		
	void Update () {
	//	if (GetComponent<enemy> ().health <= 0) {
	//		count = count + 1;
			//SetCountText ();
      }

	public void SetCountText () {
		count = count + 1;
		scoreText.text = "Score: " + count.ToString ();
	}

	public void AddScore (){
		count = count + 1;
	}
}