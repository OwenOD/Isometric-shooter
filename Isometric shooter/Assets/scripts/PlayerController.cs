using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour {

	private Camera mainCamera;

	public float bulletSpeed = 20;
	public GameObject bulletPrefab;
	public Transform bulletSpawnPoint;

	public GameObject turret;

	public KeyCode fireKey = KeyCode.Mouse0;



	NavMeshAgent agent;

	void Start () {
		agent = GetComponent<NavMeshAgent> ();

		mainCamera = FindObjectOfType<Camera> ();
	}

	public void MovePlayer(Vector3 newPosition){
		agent.SetDestination (newPosition);
	}


	void Update () {

//		if (health <= 0) {
//			Destroy (this.gameObject);
//			return;
//		}

		Ray cameraRay = mainCamera.ScreenPointToRay (Input.mousePosition);
		Plane groundPlane = new Plane (Vector3.up, Vector3.zero);
		float rayLength;

		if (Input.GetKeyDown (fireKey)) {
			GameObject GO = Instantiate (bulletPrefab, bulletSpawnPoint.position, Quaternion.identity) as GameObject;
			GO.GetComponent<Rigidbody> ().AddForce (turret.transform.forward * bulletSpeed, ForceMode.Impulse);
		}



		if (groundPlane.Raycast (cameraRay, out rayLength)) {
			Vector3 pointToLook = cameraRay.GetPoint (rayLength);
			Debug.DrawLine (cameraRay.origin, pointToLook, Color.blue);
			transform.LookAt (new Vector3 (pointToLook.x, transform.position.y, pointToLook.z));
		}
	}

//	void OnTriggerEnter(Collider other){
//		Debug.Log ("OW");
//
//		if (other.tag == "Enemy") {
//			Destroy (this.gameObject);
//		}
//    }
}