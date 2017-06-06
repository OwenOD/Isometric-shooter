using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour {

	private Camera mainCamera;

	public float movmentSpeed = 2;

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

	public void MovePlayer(Vector3 newPosition) {
		agent.SetDestination (newPosition);
	}


	void Update () {

		Movment ();

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

	private void Movment () {
		
		if (Input.GetKey (KeyCode.W)) {
			transform.position = transform.position + new Vector3 (0, 0, 0.1f) * movmentSpeed;
		}

		if (Input.GetKey (KeyCode.A)) {
			transform.position = transform.position + new Vector3 (-0.1f, 0, 0) * movmentSpeed;
		}

		if (Input.GetKey (KeyCode.S)) {
			transform.position = transform.position + new Vector3 (0, 0, -0.1f) * movmentSpeed;
		}

		if (Input.GetKey (KeyCode.D)) {
			transform.position = transform.position + new Vector3 (0.1f, 0, 0) * movmentSpeed;
		}
	}
}
