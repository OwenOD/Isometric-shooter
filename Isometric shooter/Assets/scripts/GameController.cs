using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	public GameObject movementMarker;
	public GameObject player;



	public LayerMask raycastLayerMask;


	void Update () {
		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		float distanceOfRay = 100;
		if (Physics.Raycast (ray, out hit, distanceOfRay, raycastLayerMask)) {

			if (Input.GetMouseButton (1)) {
				Debug.Log (hit.transform.tag);
				if (hit.transform.tag == "Ground") {

					movementMarker.transform.position = hit.point;

					player.GetComponent<PlayerController> ().MovePlayer (hit.point);

//					
				}

			}

		}

		if (Input.GetKey (KeyCode.Space)){
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		}

	}
}