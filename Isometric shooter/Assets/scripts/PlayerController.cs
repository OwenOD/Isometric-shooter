using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//still havent worked out this scrip yet ment to make character face curser 

public class PlayerController : MonoBehaviour {


	public float movmentSpeed = 0.1f;

	public GameObject bulletPrefab;
	public float bulletSpeed = 20;
	public Transform bulletSpawnPoint;

	public GameObject turret;

	public KeyCode fireKey = KeyCode.Mouse0;
	public KeyCode moveKey = KeyCode.Mouse1;

	private Camera mainCamera;

	Vector3 newPosition;

	void Start () {
	mainCamera = FindObjectOfType<Camera>();
	}



	void Update ()
	{   
		// fix the movment so it doesnt jump straight to position and mabey fix cameras
		// also fix shooting 
		if (Input.GetKeyDown (moveKey)) {
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, out hit))
			{
				newPosition = hit.point;
				transform.position = newPosition;
		}

		if (Input.GetKeyDown (fireKey)) {
			GameObject GO = Instantiate (bulletPrefab, bulletSpawnPoint.position, Quaternion.identity) as GameObject;
			GO.GetComponent<Rigidbody> ().AddForce (turret.transform.forward * bulletSpeed, ForceMode.Impulse);
		}


		// for object to face the mouse position      
		Ray cameraRay = mainCamera.ScreenPointToRay (Input.mousePosition);
		Plane groundPlane = new Plane (Vector3.up, Vector3.zero);
		float rayLength;

		if (groundPlane.Raycast (cameraRay, out rayLength)) {
			Vector3 pointToLook = cameraRay.GetPoint (rayLength);
			Debug.DrawLine (cameraRay.origin, pointToLook, Color.blue);
			transform.LookAt (new Vector3 (pointToLook.x, transform.position.y, pointToLook.z));
		}

	}
 }
}







		


	





