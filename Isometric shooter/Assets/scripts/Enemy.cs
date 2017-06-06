using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy : MonoBehaviour {

	public bool playerDeath; 

	public float deathRange =1;
	public float detectionRange =12;

	public GameObject targetPlayer;
	public GameObject gm;
	public GameObject spawner;
	public GameObject playerController;

	private NavMeshAgent navAgent;

	public int health = 6;



	public void TakeDamage(int damage) {
		health = health - damage;

		if (health <= 0) {
			Destroy (this.gameObject);
			gm.GetComponent<score>().SetCountText();
		}
	}


	void Start () {
		spawner = GameObject.FindGameObjectWithTag ("spawns");
		playerController = GameObject.FindGameObjectWithTag ("Player");
		targetPlayer = GameObject.FindGameObjectWithTag ("Player");
		navAgent = GetComponent<NavMeshAgent> ();
		gm = GameObject.FindGameObjectWithTag ("GameManager");
		playerDeath = true;
	}


//	void Update () {
////		// makes the enemy track the player 
////		if (Vector3.Distance (transform.position, targetPlayer.transform.position) < detectionRange) {
////			navAgent.destination = targetPlayer.transform.position;
////		}
////
////		// makes the enemy tack the empty insted of the player
//		if (playerDeath == true){
//			Destroy (this.gameObject); 
//			Vector3.Distance (transform.position, targetEmpty.transform.position) < detectionRange;
//
//			navAgent.destination = targetEmpty.transform.position;
//		}
////
////		// destroys player on contact 
////		if (Vector3.Distance (transform.position, targetPlayer.transform.position) < deathRange) {
////			playerDead = true;
////			Destroy (targetPlayer.gameObject);
////			//			    Destroy (spawner.GetComponent<Spawner>());
////			//			    spawner.GetComponent<Spawner>().SetActive (false);
////			Debug.Log (playerDead);
////		}
//	}

	void Update () {


//		// makes the enemy tack the empty insted of the player
		 if (Vector3.Distance (transform.position, targetPlayer.transform.position) < detectionRange) {
			navAgent.destination = targetPlayer.transform.position;
		}
		//Vector3.Distance (transform.position, targetEmpty.transform.position) < detectionRange;

		//navAgent.destination = targetEmpty.transform.position;


		// destroys player on contact 
		if (Vector3.Distance (transform.position, targetPlayer.transform.position) < deathRange) {
			playerController.SetActive (false); 
//			playerDeath = false;
//			Debug.Log (playerDeath);
//			Destroy (targetPlayer.gameObject);
			//			    Destroy (spawner.GetComponent<Spawner>());
			spawner.SetActive (false);
//			if (playerDeath == true){
//		    Destroy (this.gameObject);
		}
	}
}

//	void DestroyEnemies(){
//		if(playerDead == true)
//			Object<enemy> 
//			}


