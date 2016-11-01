using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {


	public AudioClip[] audioClip;



	public void PlaySound(int clip){


		AudioSource audio = GetComponent<AudioSource> ();
		audio.clip = audioClip [clip];
		audio.Play ();


	}



}


