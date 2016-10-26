using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerMotor : MonoBehaviour {

	private  float speed = 0f;
	private float idleSpeed = 0f;
	public float moveSpeed = 6f; //Player Speed.
	public int Lives = 3; //Players totals lives.


	private Rigidbody2D myRB2D;
	private GameManager gameManager;


	// Use this for initialization
	void Start () {

		myRB2D = GetComponent<Rigidbody2D> (); //Getting the Rigidbody2D.
		gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
	
	}
	
	// Update is called once per frame
	void Update () {



		myRB2D.velocity = new Vector2 (moveSpeed, myRB2D.velocity.y); // The force to keep the player moving forward.

		 if (Input.GetKey(KeyCode.LeftArrow) ||  Input.GetKey(KeyCode.A)){
		  Movement(Vector3.left);
		
		}
		 
		if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)){

		  Movement(Vector3.right);
		
		}

	

		if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)){ // move up.
			Movement(Vector3.up);
	

		}

		if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)){ // move down.
			Movement(Vector3.down);
		
		}

	
		if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S)) { // push speed.
		
		
			speed = idleSpeed;
		}
	
	}




	void Movement(Vector3 dir){ // Player Movement.
		speed = moveSpeed;
		transform.position += dir.normalized * speed * Time.deltaTime;
	
	}




	void OnCollisionEnter2D(Collision2D other){


		if (other.collider.gameObject.tag == "EnemyObject") {


			Destroy (gameObject);
			gameManager.TakeLives (1);
			gameManager.SpawnThePlayer ();
			// waiting to fix a bug when this happen.


		}


	}
}
