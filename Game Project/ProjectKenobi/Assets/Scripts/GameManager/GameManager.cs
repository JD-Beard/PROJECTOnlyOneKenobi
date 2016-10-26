using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	int PlayerLives = 3; // static of player lives.
	static int ItemPickPoints = 0; // static points for pick up.
	public Text itemText; // text var
	public Text livesText; // text var
	public GameObject spawnPlayer;
	public Transform spawnPoint;

	private SpeedController SC;



	// Use this for initialization
	void Start () {

		itemText.text = "MIDICHLORIANS: " + ItemPickPoints; // set the beginning score.
		livesText.text = "Lives: " + PlayerLives; // set the player lives.
		SC =GameObject.Find ("SpeedManager").GetComponent<SpeedController> ();

	
	}
	
	// Update is called once per frame
	void Update () {


		if (PlayerLives == 0) {

			GameOver ();

		}


		if (ItemPickPoints == 15) {

			WinningGame ();

		}
	
	}



	public void AddItemPoints(int pointsToAdd){ // function for the points to add.

		ItemPickPoints = ItemPickPoints + pointsToAdd;
		itemText.text = "MIDICHLORIANS: " + ItemPickPoints;


	}

	public void TakeLives(int pointsToTake){ // function for the player lives.

		PlayerLives = PlayerLives - pointsToTake;
		livesText.text = "Lives: " + PlayerLives;


	}


public void SpawnThePlayer(){ /// waiting to fix this bug before we go on any farther.

		if (PlayerLives > 0) {
			
			StartCoroutine (BeginSpawning ());



		}
	}

	IEnumerator BeginSpawning(){

		yield return new WaitForSeconds (2);
		GameObject temp = Instantiate (spawnPlayer, spawnPoint.position, spawnPoint.rotation) as GameObject;
		temp.GetComponent<PlayerMotor> ().SetSpeed (SC.difficultyLevel);




	


	}


	public void WinningGame(){

		StartCoroutine (BeginWinScene ());

	}

	IEnumerator BeginWinScene(){

		yield return new WaitForSeconds (2);
		//SceneManager.LoadScene ("Winner");
		//Debug.Log("You Won the game");



	}



	public void GameOver(){


		StartCoroutine (BeginGameover ());


	}


	IEnumerator BeginGameover(){

		yield return new WaitForSeconds (2);
		//SceneManager.LoadScene ("GameOver");
		//Debug.Log("GameOver");



	}
}
