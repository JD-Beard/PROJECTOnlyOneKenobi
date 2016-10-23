using UnityEngine;
using System.Collections;

public class Items : MonoBehaviour {

	private GameManager manager; // GameManager Script

	// Use this for initialization
	void Start () {

		Destroy (gameObject, 7f); // Destroy this item after 7 secs.
		manager = GameObject.Find ("GameManager").GetComponent<GameManager> (); //Find the Gamemanager script in the scene.
	
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}



	void OnTriggerEnter2D(Collider2D other){

		if (other.gameObject.tag == "Player") { // if the player collider do this.


			gameObject.SetActive (false); //  turn the item off.
			manager.AddItemPoints (1); // give the player 1 point.

		}


	}





}
