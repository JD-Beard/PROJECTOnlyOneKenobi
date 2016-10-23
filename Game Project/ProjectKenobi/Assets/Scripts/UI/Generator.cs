using UnityEngine;
using System.Collections;

public class Generator : MonoBehaviour {


	public float moveSpeed = 0.5f; //  speed for the scrolling
	private Renderer SR; // get the renderer
	// Use this for initialization
	void Start () {
		SR = GetComponent<Renderer> (); // component.

	
	}
	
	// Update is called once per frame
	void Update () {

		Vector2 offset = new Vector2(Time.time * moveSpeed, 0); // make a offset to the scrolling
		SR.material.mainTextureOffset = offset; // do the offset.

	
	}
}
