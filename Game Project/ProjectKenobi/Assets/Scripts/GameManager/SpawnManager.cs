using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour {


	public GameObject playerPickUpItems; // the item prefab.
	public GameObject objectToKillPlayer; // kill player.
	public Transform[] Spawnpoints; // An Array of spawnpoints.
	public float spawnTimer = 10f; // timer for the spawning.
	public float objectspawnTimer = 10f;
	// Use this for initialization
	void Start () {

		InvokeRepeating ("SpawningItems", spawnTimer, spawnTimer); // begin repeating the same task.
		InvokeRepeating ("SpawningObjects", objectspawnTimer, objectspawnTimer); // begin repeating the same task.
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void SpawningItems(){

		int spawnIndex = Random.Range (0, Spawnpoints.Length); // pick a random number from the spawnpoints given.
		Instantiate (playerPickUpItems, Spawnpoints [spawnIndex].position, Spawnpoints [spawnIndex].rotation); // spawn the item.




	}

	void SpawningObjects(){ // waiting to fix this bug.



		int spawnIndex = Random.Range (0, Spawnpoints.Length); // pick a random number from the spawnpoints given.
		Instantiate (objectToKillPlayer, Spawnpoints [spawnIndex].position, Spawnpoints [spawnIndex].rotation); // spawn the item.


	}
}
