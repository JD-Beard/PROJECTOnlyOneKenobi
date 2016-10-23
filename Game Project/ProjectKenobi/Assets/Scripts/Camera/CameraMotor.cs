using UnityEngine;
using System.Collections;

public class CameraMotor : MonoBehaviour {


	private PlayerMotor thePlayer; //  the Player
	private Vector3 lastPlayerPosition; // the lastPosition of the Player.
	private float distanceToMove; //  the distance you want the camera to move.
	// Use this for initialization
	void Start () {

		thePlayer = FindObjectOfType<PlayerMotor> (); // Find the PlayerScript.
	
	}
	
	// Update is called once per frame
	void Update () {


		distanceToMove = thePlayer.transform.position.x - lastPlayerPosition.x; //  the distance to move.

		transform.position = new Vector3 (transform.position.x + distanceToMove,transform.position.y, transform.position.z); // move the camera to using this vector

		lastPlayerPosition = thePlayer.transform.position; // thelastposition is the players.
	
	}
}
