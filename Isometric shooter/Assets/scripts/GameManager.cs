using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {


	// Use this for initialization
	void Start () 
	{
		
	}

	// Update is called once per frame
	void Update () {
		refresh ();
		
		//make timer reset 
		Debug.Log (Time.time);



	}

	private void refresh () {
		
		if (Input.GetKey (KeyCode.Space)) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		}



	}

}