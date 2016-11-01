using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour
{


	public GameObject playerPickUpItems;
	// the item prefab.
	// kill player.
	public Transform[] Spawnpoints;
	// An Array of spawnpoints.
	public float spawnTimer = 10f;
	// timer for the spawning.


	void Start ()
	{

		InvokeRepeating ("SpawningItems", spawnTimer, spawnTimer); // begin repeating the same task.

	
	}

	void SpawningItems ()
	{

		int spawnIndex = Random.Range (0, Spawnpoints.Length); // pick a random number from the spawnpoints given.
		Instantiate (playerPickUpItems, Spawnpoints [spawnIndex].position, Spawnpoints [spawnIndex].rotation); // spawn the item.




	}


}
