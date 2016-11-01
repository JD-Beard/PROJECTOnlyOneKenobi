using UnityEngine;
using System.Collections;

public class Items : MonoBehaviour
{

	private GameManager manager;
	private Rigidbody2D myRB2D;
	public float moveSpeed;
	public Transform particles;
	private float speed;
	private SoundManager sManager;


	void Start ()
	{

		Destroy (gameObject, 7f); // Destroy this item after 7 secs.
		manager = GameObject.Find ("GameManager").GetComponent<GameManager> (); //Find the Gamemanager script in the scene.
		sManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();
		myRB2D = GetComponent<Rigidbody2D> ();
	
	}
	
	// Update is called once per frame
	void Update ()
	{

		myRB2D.velocity = new Vector2 (moveSpeed, myRB2D.velocity.y);
	
	}



	void OnTriggerEnter2D (Collider2D other)
	{

		if (other.gameObject.tag == "Player") { // if the player collider do this.

			sManager.PlaySound (0);
			gameObject.SetActive (false); //  turn the item off.
			manager.AddItemPoints (1); // give the player 1 point.
			Instantiate(particles,transform.position,transform.rotation);

		}


	}





}
