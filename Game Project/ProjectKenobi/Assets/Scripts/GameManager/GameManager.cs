using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	static int PlayerLives = 3; // static of player lives.
	static int ItemPickPoints = 0; // static points for pick up.
	public Text itemText; // text var
	public Text livesText; // text var
	//public GameObject spawnPlayer;

	// Use this for initialization
	void Start () {

		itemText.text = "MIDICHLORIANS: " + ItemPickPoints; // set the beginning score.
		livesText.text = "Lives: " + PlayerLives; // set the player lives.

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}



	public void AddItemPoints(int pointsToAdd){ // function for the points to add.

		ItemPickPoints = ItemPickPoints + pointsToAdd;
		itemText.text = "MIDICHLORIANS: " + ItemPickPoints;


	}

	public void TakeLives(int pointsToTake){ // function for the player lives.

		PlayerLives = PlayerLives - pointsToTake;
		livesText.text = "Lives: " + ItemPickPoints;


	}


//	public void SpawnThePlayer(){ /// waiting to fix this bug before we go on any farther.
//
//
//		StartCoroutine (BeginSpawning ());
//		PlayerLives--;
//
//	}

//	IEnumerator BeginSpawning(){
//
//		yield return new WaitForSeconds (2);
//		Instantiate (spawnPlayer, transform.position, Quaternion.identity);
//
//
//	}
}
