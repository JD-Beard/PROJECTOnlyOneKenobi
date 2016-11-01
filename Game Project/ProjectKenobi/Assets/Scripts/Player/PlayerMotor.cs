using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerMotor : MonoBehaviour
{

	private  float speed = 0f;
	private float idleSpeed = 0f;
	public float playerSpeed = 18f;
	// player Speed;
	public int Lives = 3;
	//Players totals lives.
	private Animator playerAnim;
	private GameManager gameManager;
	private SoundManager soundManager;





	// Use this for initialization
	void Start ()
	{

	
		gameManager = GameObject.Find ("GameManager").GetComponent<GameManager> ();
		soundManager = GameObject.Find ("SoundManager").GetComponent<SoundManager> ();

	
		playerAnim = GetComponent<Animator> ();
		playerSpeed = 18f;

	


	}


	void Update ()
	{

	

	

		if (Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.A)) {
			Movement (Vector3.left);
		
		}
		 
		if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.D)) {

			Movement (Vector3.right);
		
		}

	

		if (Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.W)) { // move up.
			Movement (Vector3.up);
	

		}

		if (Input.GetKey (KeyCode.DownArrow) || Input.GetKey (KeyCode.S)) { // move down.
			Movement (Vector3.down);
		
		}

	
		if (Input.GetKeyUp (KeyCode.UpArrow) || Input.GetKeyUp (KeyCode.DownArrow) || Input.GetKeyUp (KeyCode.W) || Input.GetKeyUp (KeyCode.S)) { // push speed.
		
		
			speed = idleSpeed;
		}




	
	}




	void Movement (Vector3 dir)
	{ // Player Movement.
		speed = playerSpeed;
		transform.position += dir.normalized * speed * Time.deltaTime;
	
	}

	public void SetSpeed (float modifier)
	{ // while you alive

		playerSpeed = 8.0f + modifier + 1;



	}

	IEnumerator Death ()
	{

		yield return new WaitForSeconds (1);

		Destroy (gameObject);
		gameManager.SpawnThePlayer ();
	}





  



	void OnCollisionEnter2D (Collision2D other)
	{


		if (other.collider.gameObject.tag == "EnemyObject") {

			playerAnim.SetBool ("Death", true);
			StartCoroutine (Death ());
			gameManager.TakeLives (1);
			soundManager.PlaySound (1);


		



		}


	}





}
