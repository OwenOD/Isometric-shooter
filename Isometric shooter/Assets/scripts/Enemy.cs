using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour {

	public float deathRnage =1;
	public float detectionRange =12;
	public GameObject player;
	private NavMeshAgent navAgent;

	public int health =6;

	public void TakenDamage(int damageToTake){
		health = health - damageToTake;
	}



	void Start () {

		if (health <= 0) {
			return;
		}

		player = GameObject.FindGameObjectWithTag ("Player");
		navAgent = GetComponent<NavMeshAgent> ();
	}


	void Update () {
		if (Vector3.Distance (transform.position, player.transform.position) < detectionRange) {
			navAgent.destination = player.transform.position;
		}

		if (Vector3.Distance (transform.position, player.transform.position) < deathRnage) {
			Destroy (player.gameObject);
			
		}
	}



}