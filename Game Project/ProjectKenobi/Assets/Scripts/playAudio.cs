using UnityEngine;
using System.Collections;

public class playAudio : MonoBehaviour
{

    void OnTriggerEnter()
    {
        GetComponent<AudioSource>().Play();
    }
    void OnTriggerExit()
    {
        GetComponent<AudioSource>().Stop();
    }
}