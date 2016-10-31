using UnityEngine;
using System.Collections;

public class Scroller : MonoBehaviour
{



	private Rigidbody2D myRB2D;
	public float moveSpeed;
	private float speed;
	// Use this for initialization
	void Start ()
	{



	
		myRB2D = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update ()
	{


		myRB2D.velocity = new Vector2 (moveSpeed, myRB2D.velocity.y);


	}
}





