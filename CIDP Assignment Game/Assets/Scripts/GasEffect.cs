using UnityEngine;
using System.Collections;

public class GasEffect : MonoBehaviour {
	private AudioSource audioSource;



	void Awake () {
		audioSource = GetComponent <AudioSource> ();
	}

	public void Play()
	{
		audioSource.Play ();
	}

}
