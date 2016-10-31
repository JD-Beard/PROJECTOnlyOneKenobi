using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

	int PlayerLives = 3;
	// static of player lives.
	static int ItemPickPoints = 0;
	// static points for pick up.
	public Text itemText;
	// text var
	public Text livesText;
	// text var
	public GameObject spawnPlayer;
	// spawn the player.
	public Transform spawnPoint;
	//  the spawn point that would be used.

	private SpeedController SC;
	// get the speedcontroller script.




	void Start ()
	{

		itemText.text = "MIDICHLORIANS: " + ItemPickPoints; // set the beginning score.
		livesText.text = "Lives: " + PlayerLives; // set the player lives.
		SC = GameObject.Find ("SpeedManager").GetComponent<SpeedController> (); //find the object with the script.

	
	}
	

	void Update ()
	{


		if (PlayerLives == 0) { // check if the player lives  = 0

			GameOver (); // play the gameover function.

		}


		if (ItemPickPoints == 15) { // check if the player has pick up 15 items.

			WinningGame (); // play the winning game function.

		}
	
	}



	public void AddItemPoints (int pointsToAdd)
	{ // function for the points to add.

		ItemPickPoints = ItemPickPoints + pointsToAdd;
		itemText.text = "MIDICHLORIANS: " + ItemPickPoints;


	}

	public void TakeLives (int pointsToTake)
	{ // function for the player lives.

		PlayerLives = PlayerLives - pointsToTake;
		livesText.text = "Lives: " + PlayerLives;


	}


	public void SpawnThePlayer ()
	{ /// waiting to fix this bug before we go on any farther.

		if (PlayerLives > 0) {
			
			StartCoroutine (BeginSpawning ());



		}
	}

	IEnumerator BeginSpawning ()
	{ // used to spawn the player with a timer.

		yield return new WaitForSeconds (2);
		GameObject temp = Instantiate (spawnPlayer, spawnPoint.position, spawnPoint.rotation) as GameObject;
		temp.GetComponent<PlayerMotor> ().SetSpeed (SC.difficultyLevel);




	


	}


	public void WinningGame ()
	{

		StartCoroutine (BeginWinScene ());

	}

	IEnumerator BeginWinScene ()
	{ // used to play the scene for winning.

		yield return new WaitForSeconds (2);
		//SceneManager.LoadScene ("Winner");
		//Debug.Log("You Won the game");



	}



	public void GameOver ()
	{


		StartCoroutine (BeginGameover ());


	}


	IEnumerator BeginGameover ()
	{ // used to play the scene for gameover.

		yield return new WaitForSeconds (2);
		//SceneManager.LoadScene ("GameOver");
		//Debug.Log("GameOver");



	}
}
