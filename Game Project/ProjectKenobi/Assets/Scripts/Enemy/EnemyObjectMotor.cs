﻿using UnityEngine;
using System.Collections;

public class EnemyObjectMotor : MonoBehaviour
{


	private Rigidbody2D myRB2D;
	public float moveSpeed;
	private float speed;
	private SoundManager soundManager;
	public Transform particles;
	// Use this for initialization
	void Start ()
	{

		Destroy (gameObject, 7f);
		myRB2D = GetComponent<Rigidbody2D> ();
		soundManager = GameObject.Find ("SoundManager").GetComponent<SoundManager> ();
	
	}
	
	// Update is called once per frame
	void Update ()
	{

		myRB2D.velocity = new Vector2 (moveSpeed, myRB2D.velocity.y);
	
	}






	void OnCollisionEnter2D (Collision2D other)
	{

		if (other.collider.gameObject.tag == "Player") {

			Destroy (gameObject);
			Instantiate(particles,transform.position,transform.rotation);
			soundManager.PlaySound (2);

		}




	}
}
