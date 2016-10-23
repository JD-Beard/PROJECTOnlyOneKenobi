using UnityEngine;
using System.Collections;

public class EnemyObjectMotor : MonoBehaviour {

	// Use this for initialization
	void Start () {

		Destroy (gameObject, 7f);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}






	void OnCollisionEnter2D(Collision2D other){

		if (other.collider.gameObject.tag == "Player") {

			Destroy (gameObject);

		}




	}
}
