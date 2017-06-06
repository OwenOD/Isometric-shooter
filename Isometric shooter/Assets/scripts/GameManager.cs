using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public GameObject enemy;
	public GameObject player; 
	public bool playerDeath;

	// Use this for initialization
	void Start () {
		playerDeath = true;
		enemy = GameObject.FindGameObjectWithTag ("Enemy");
		player = GameObject.FindGameObjectWithTag ("Player");
		//enemy = FindObjectOfType<enemy> ();
	}

	// Update is called once per frame
	void Update () {
		
		refresh ();

//		if (GetComponent <enemy> ().playerDeath == false) {
//			Destroy (enemy.gameObject);
//		}
	}
//-----------------------------------------------------------------------------------------
// private void refresh () 
//
// Param: 
//      Input.GetKey - when a spasific key is pressed  
//      KeyCode.Space - the key assined that will activate the IF   
//      SceneManager.LoadScene - loads a scene 		
//      SceneManager.GetActiveScene - graps the current scene 
//----------------------------------------------------------------------------------------

	private void refresh () {
		
		if (Input.GetKey (KeyCode.Space)) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		}
	}

//	private void StopSpawner () {
//		if (GetComponent<PlayerController> = )


	

}