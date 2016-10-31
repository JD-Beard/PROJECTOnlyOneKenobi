using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour
{


	public GameObject playerPickUpItems;
	// the item prefab.
	public GameObject objectToKillPlayer;
	// kill player.
	public GameObject objectToKillPlayer1;
	// kill player.
	public GameObject objectToKillPlayer2;
	// kill player.
	public Transform[] Spawnpoints;
	// An Array of spawnpoints.
	public float spawnTimer = 10f;
	// timer for the spawning.
	public float objectspawnTimer = 10f;
	// timer for the spawning.
	public float objectspawnTimer1 = 15f;
	// timer for the spawning.
	public float objectspawnTimer2 = 20f;

	void Start ()
	{

		InvokeRepeating ("SpawningItems", spawnTimer, spawnTimer); // begin repeating the same task.
		InvokeRepeating ("SpawningObjects", objectspawnTimer, objectspawnTimer); // begin repeating the same task.
		InvokeRepeating ("SpawningObjects1", objectspawnTimer1, objectspawnTimer1); // begin repeating the same task
		InvokeRepeating ("SpawningObjects2", objectspawnTimer2, objectspawnTimer2); // begin repeating the same task
	
	}

	
	void Update ()
	{
	
	}


	void SpawningItems ()
	{

		int spawnIndex = Random.Range (0, Spawnpoints.Length); // pick a random number from the spawnpoints given.
		Instantiate (playerPickUpItems, Spawnpoints [spawnIndex].position, Spawnpoints [spawnIndex].rotation); // spawn the item.




	}

	void SpawningObjects ()
	{ // waiting to fix this bug.



		int spawnIndex = Random.Range (0, Spawnpoints.Length); // pick a random number from the spawnpoints given.
		Instantiate (objectToKillPlayer, Spawnpoints [spawnIndex].position, Spawnpoints [spawnIndex].rotation); // spawn the item.


	}

	void SpawningObjects1 ()
	{ // waiting to fix this bug.



		int spawnIndex = Random.Range (0, Spawnpoints.Length); // pick a random number from the spawnpoints given.
		Instantiate (objectToKillPlayer1, Spawnpoints [spawnIndex].position, Spawnpoints [spawnIndex].rotation); // spawn the item.


	}


	void SpawningObjects2 ()
	{ // waiting to fix this bug.



		int spawnIndex = Random.Range (0, Spawnpoints.Length); // pick a random number from the spawnpoints given.
		Instantiate (objectToKillPlayer2, Spawnpoints [spawnIndex].position, Spawnpoints [spawnIndex].rotation); // spawn the item.


	}
}
