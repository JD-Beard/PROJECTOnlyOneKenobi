using UnityEngine;
using System.Collections;

public class SpeedController : MonoBehaviour {

	public int difficultyLevel = 1;
	private int maxDiffiucltyLevel = 10;
	public int scoreToNextLevel = 3000;
	private PlayerMotor playerMovement;
	private Generator fieldSpeed;
	public float pointsPerSecond;
	public bool scoreIncreasing;
	public float scoreCount;




	// Use this for initialization
	void Start () {

		playerMovement = FindObjectOfType<PlayerMotor> ();
		fieldSpeed = FindObjectOfType<Generator> ();
		scoreIncreasing = true;
	
	}
	
	// Update is called once per frame
	void Update () {

	


		if (scoreIncreasing) {

			scoreCount += pointsPerSecond * Time.deltaTime;

		}

		if (scoreCount >= scoreToNextLevel) {

			playerMovement = FindObjectOfType<PlayerMotor> ();
			SpeedUP ();

		}


	}
}


public	class void SpeedUP(){

		Debug.Log ("LevelUP" + difficultyLevel);
	
		if (difficultyLevel == maxDiffiucltyLevel)
			return;

	scoreToNextLevel *= 2;
		difficultyLevel++;

		playerMovement.SetSpeed(difficultyLevel);
		fieldSpeed.SetSpeed (difficultyLevel - 2.0f);



	}
}
}
}