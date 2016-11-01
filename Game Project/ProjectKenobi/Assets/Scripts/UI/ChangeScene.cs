using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

	public void ChangeToScene(int SceneToChangeTo){

		SceneManager.LoadScene (SceneToChangeTo);

	}

	public void ChangeToExit(int sceneToExitTo){


		Application.Quit ();
	}


}
