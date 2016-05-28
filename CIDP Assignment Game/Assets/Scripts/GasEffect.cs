using UnityEngine;
using System.Collections;

public class GasEffect : MonoBehaviour {
	private AudioSource audioSource;


	// with this function it will be by passing through the audio inserted by the user.
	void Awake () {
		audioSource = GetComponent <AudioSource> ();
	}

	// this function enables the adiou to play
	public void Play()
	{
		audioSource.Play ();
	}

}
