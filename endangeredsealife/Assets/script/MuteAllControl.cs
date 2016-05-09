using UnityEngine;
using System.Collections;

public class MuteAllControl : MonoBehaviour {
	 
	bool hasSound = true;

	public void toggle()
	{
		hasSound = !hasSound;
		Camera.main.GetComponent <AudioListener> ().enabled = hasSound;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
